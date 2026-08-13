#nullable enable

namespace BytePlusSeedSpeech
{
    public partial interface IBytePlusSeedSpeechClient
    {
        /// <summary>
        /// Generate audio with Seed Audio 1.0.<br/>
        /// Generates up to 120 seconds of audio from a natural-language prompt, optionally conditioned on as many as three audio references or one image reference. Reference audio can also be supplied by a TTS 2.0 or cloned speaker ID.
        /// </summary>
        /// <param name="xApiRequestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BytePlusSeedSpeech.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BytePlusSeedSpeech.CreateAudioResponse> CreateAudioAsync(

            global::BytePlusSeedSpeech.CreateAudioRequest request,
            string? xApiRequestId = default,
            global::BytePlusSeedSpeech.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate audio with Seed Audio 1.0.<br/>
        /// Generates up to 120 seconds of audio from a natural-language prompt, optionally conditioned on as many as three audio references or one image reference. Reference audio can also be supplied by a TTS 2.0 or cloned speaker ID.
        /// </summary>
        /// <param name="xApiRequestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BytePlusSeedSpeech.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BytePlusSeedSpeech.AutoSDKHttpResponse<global::BytePlusSeedSpeech.CreateAudioResponse>> CreateAudioAsResponseAsync(

            global::BytePlusSeedSpeech.CreateAudioRequest request,
            string? xApiRequestId = default,
            global::BytePlusSeedSpeech.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate audio with Seed Audio 1.0.<br/>
        /// Generates up to 120 seconds of audio from a natural-language prompt, optionally conditioned on as many as three audio references or one image reference. Reference audio can also be supplied by a TTS 2.0 or cloned speaker ID.
        /// </summary>
        /// <param name="xApiRequestId"></param>
        /// <param name="model">
        /// Model version identifier. Use seed-audio-1.0.<br/>
        /// Example: seed-audio-1.0
        /// </param>
        /// <param name="textPrompt">
        /// Natural-language audio prompt or text to synthesize. Use @Audio1, @Audio2, and @Audio3 to address audio references in upload order.
        /// </param>
        /// <param name="references">
        /// Optional reference resources. Supply up to three audio references or one image reference; image and audio references cannot be mixed.
        /// </param>
        /// <param name="audioConfig">
        /// Output audio configuration.
        /// </param>
        /// <param name="watermark">
        /// Explicit and implicit audio watermark configuration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BytePlusSeedSpeech.CreateAudioResponse> CreateAudioAsync(
            string model,
            string textPrompt,
            string? xApiRequestId = default,
            global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.AudioReference>? references = default,
            global::BytePlusSeedSpeech.AudioConfig? audioConfig = default,
            global::BytePlusSeedSpeech.WatermarkConfig? watermark = default,
            global::BytePlusSeedSpeech.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}