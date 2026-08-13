<div class="docs-hero">
  <h1>BytePlusSeedSpeech</h1>
  <p class="docs-hero-lead">Modern .NET SDK for BytePlus Seed Speech, with typed support for Seed Audio 1.0 generation.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/BytePlusSeedSpeech/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/BytePlusSeedSpeech"></a>
    <a href="https://github.com/tryAGI/BytePlusSeedSpeech/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/BytePlusSeedSpeech/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/BytePlusSeedSpeech/blob/main/LICENSE"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/BytePlusSeedSpeech"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from a checked-in <a href="src/libs/BytePlusSeedSpeech/openapi.yaml">OpenAPI definition</a> based on BytePlus's official <a href="https://docs.byteplus.com/en/docs/byteplusvoice/seedaudio-01">Audio 1.0 API reference</a>.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using BytePlusSeedSpeech;

using var client = new BytePlusSeedSpeechClient(apiKey);
```

The API key is available from the BytePlus Seed Speech console. The SDK sends it
in the required `X-Api-Key` header and defaults to the Singapore Seed Speech
endpoint.

<!-- EXAMPLES:START -->
### Generate audio
Generate dialogue, sound effects, and ambience from one prompt with Seed Audio 1.0.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/BytePlusSeedSpeech/issues">tryAGI/BytePlusSeedSpeech</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/BytePlusSeedSpeech/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
