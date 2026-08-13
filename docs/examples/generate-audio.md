# Generate audio

Generate dialogue, sound effects, and ambience from one prompt with Seed Audio 1.0.

This example assumes `using BytePlusSeedSpeech;` is in scope and `apiKey` contains your BytePlusSeedSpeech API key.

```csharp
using var client = new BytePlusSeedSpeechClient(apiKey);

var response = await client.CreateAudioAsync(new CreateAudioRequest
{
    Model = "seed-audio-1.0",
    TextPrompt =
        "Inside a football stadium, the crowd erupts as the commentator shouts: \"What a goal!\"",
    AudioConfig = new AudioConfig
    {
        Format = AudioFormat.Wav,
        SampleRate = 24000,
        EnableSubtitle = true,
    },
    Watermark = new WatermarkConfig
    {
        AigcWatermark = false,
    },
});
```