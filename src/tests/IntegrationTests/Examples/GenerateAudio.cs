/*
order: 10
title: Generate audio
slug: generate-audio

Generate dialogue, sound effects, and ambience from one prompt with Seed Audio 1.0.
*/

namespace BytePlusSeedSpeech.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateAudio()
    {
        using var client = GetAuthenticatedClient();

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

        (response.Audio is { Length: > 0 } || response.Url is { Length: > 0 }).Should().BeTrue();
    }
}
