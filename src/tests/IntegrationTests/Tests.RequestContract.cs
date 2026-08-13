using System.Net;
using System.Text;
using System.Text.Json;

namespace BytePlusSeedSpeech.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateAudioSendsDocumentedRequestContract()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new BytePlusSeedSpeechClient(
            apiKey: "test-api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://voice.example.test/api/v3"),
            disposeHttpClient: false);

        var response = await client.CreateAudioAsync(
            request: new CreateAudioRequest
            {
                Model = "seed-audio-1.0",
                TextPrompt = "Use @Audio1 as the narrator, with quiet rain behind the dialogue.",
                References =
                [
                    new AudioReference
                    {
                        Speaker = "test-speaker",
                    },
                ],
                AudioConfig = new AudioConfig
                {
                    Format = AudioFormat.OggOpus,
                    SampleRate = 48000,
                    SpeechRate = 10,
                    LoudnessRate = -5,
                    PitchRate = 2,
                    EnableSubtitle = true,
                },
                Watermark = new WatermarkConfig
                {
                    AigcWatermark = true,
                    AigcMetadata = new AigcMetadata
                    {
                        Enable = true,
                        ContentProducer = "tryAGI",
                        ProduceId = "audio-123",
                    },
                },
            },
            xApiRequestId: "request-123");

        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://voice.example.test/api/v3/tts/create"));
        handler.ApiKey.Should().Be("test-api-key");
        handler.RequestId.Should().Be("request-123");

        using var body = JsonDocument.Parse(handler.Body!);
        var root = body.RootElement;
        root.GetProperty("model").GetString().Should().Be("seed-audio-1.0");
        root.GetProperty("references")[0].GetProperty("speaker").GetString().Should().Be("test-speaker");
        root.GetProperty("audio_config").GetProperty("format").GetString().Should().Be("ogg_opus");
        root.GetProperty("audio_config").GetProperty("enable_subtitle").GetBoolean().Should().BeTrue();
        root.GetProperty("watermark").GetProperty("aigc_metadata").GetProperty("produce_id")
            .GetString().Should().Be("audio-123");

        response.Audio.Should().Equal(1, 2, 3);
        response.Duration.Should().Be(1.25);
        response.OriginalDuration.Should().Be(1.5);
        response.Subtitle!.Sentences.Should().ContainSingle();
        response.Subtitle.Sentences![0].Words.Should().ContainSingle();
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public string? ApiKey { get; private set; }
        public string? RequestId { get; private set; }
        public string? Body { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            ApiKey = request.Headers.GetValues("X-Api-Key").Single();
            RequestId = request.Headers.GetValues("X-Api-Request-Id").Single();
            Body = await request.Content!.ReadAsStringAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """
                    {
                      "audio": "AQID",
                      "duration": 1.25,
                      "original_duration": 1.5,
                      "url": "https://voice.example.test/audio.wav",
                      "subtitle": {
                        "text": "Hello.",
                        "sentences": [
                          {
                            "start_time": 0,
                            "end_time": 1250,
                            "text": "Hello.",
                            "words": [
                              { "start_time": 0, "end_time": 1250, "text": "Hello." }
                            ]
                          }
                        ]
                      }
                    }
                    """,
                    Encoding.UTF8,
                    "application/json"),
            };
        }
    }
}
