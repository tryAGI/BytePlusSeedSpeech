
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAudioResponse
    {
        /// <summary>
        /// Provider status code, when returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Provider status message, when returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Base64-encoded synthesized audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public byte[]? Audio { get; set; }

        /// <summary>
        /// Post-processed audio duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Original model output duration in seconds, used for billing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_duration")]
        public double? OriginalDuration { get; set; }

        /// <summary>
        /// Generated audio URL, valid for two hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public global::BytePlusSeedSpeech.Subtitle? Subtitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// Provider status code, when returned.
        /// </param>
        /// <param name="message">
        /// Provider status message, when returned.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded synthesized audio.
        /// </param>
        /// <param name="duration">
        /// Post-processed audio duration in seconds.
        /// </param>
        /// <param name="originalDuration">
        /// Original model output duration in seconds, used for billing.
        /// </param>
        /// <param name="url">
        /// Generated audio URL, valid for two hours.
        /// </param>
        /// <param name="subtitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioResponse(
            int? code,
            string? message,
            byte[]? audio,
            double? duration,
            double? originalDuration,
            string? url,
            global::BytePlusSeedSpeech.Subtitle? subtitle)
        {
            this.Code = code;
            this.Message = message;
            this.Audio = audio;
            this.Duration = duration;
            this.OriginalDuration = originalDuration;
            this.Url = url;
            this.Subtitle = subtitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioResponse" /> class.
        /// </summary>
        public CreateAudioResponse()
        {
        }

    }
}