
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAudioRequest
    {
        /// <summary>
        /// Model version identifier. Use seed-audio-1.0.<br/>
        /// Example: seed-audio-1.0
        /// </summary>
        /// <example>seed-audio-1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Natural-language audio prompt or text to synthesize. Use @Audio1, @Audio2, and @Audio3 to address audio references in upload order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// Optional reference resources. Supply up to three audio references or one image reference; image and audio references cannot be mixed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.AudioReference>? References { get; set; }

        /// <summary>
        /// Output audio configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_config")]
        public global::BytePlusSeedSpeech.AudioConfig? AudioConfig { get; set; }

        /// <summary>
        /// Explicit and implicit audio watermark configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public global::BytePlusSeedSpeech.WatermarkConfig? Watermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioRequest(
            string model,
            string textPrompt,
            global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.AudioReference>? references,
            global::BytePlusSeedSpeech.AudioConfig? audioConfig,
            global::BytePlusSeedSpeech.WatermarkConfig? watermark)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.References = references;
            this.AudioConfig = audioConfig;
            this.Watermark = watermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioRequest" /> class.
        /// </summary>
        public CreateAudioRequest()
        {
        }

    }
}