
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    /// A reference resource. For audio, provide exactly one of speaker, audio_data, or audio_url. For an image, provide exactly one of image_data or image_url. Image and audio fields cannot be mixed.
    /// </summary>
    public sealed partial class AudioReference
    {
        /// <summary>
        /// TTS 2.0 or cloned voice speaker ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Base64-encoded wav, mp3, pcm, or ogg_opus reference audio. Each clip can be up to 30 seconds and 10 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_data")]
        public byte[]? AudioData { get; set; }

        /// <summary>
        /// URL of a wav, mp3, pcm, or ogg_opus reference audio clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Base64-encoded jpeg, png, or webp reference image, up to 10 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_data")]
        public byte[]? ImageData { get; set; }

        /// <summary>
        /// URL of a jpeg, png, or webp reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioReference" /> class.
        /// </summary>
        /// <param name="speaker">
        /// TTS 2.0 or cloned voice speaker ID.
        /// </param>
        /// <param name="audioData">
        /// Base64-encoded wav, mp3, pcm, or ogg_opus reference audio. Each clip can be up to 30 seconds and 10 MB.
        /// </param>
        /// <param name="audioUrl">
        /// URL of a wav, mp3, pcm, or ogg_opus reference audio clip.
        /// </param>
        /// <param name="imageData">
        /// Base64-encoded jpeg, png, or webp reference image, up to 10 MB.
        /// </param>
        /// <param name="imageUrl">
        /// URL of a jpeg, png, or webp reference image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioReference(
            string? speaker,
            byte[]? audioData,
            string? audioUrl,
            byte[]? imageData,
            string? imageUrl)
        {
            this.Speaker = speaker;
            this.AudioData = audioData;
            this.AudioUrl = audioUrl;
            this.ImageData = imageData;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioReference" /> class.
        /// </summary>
        public AudioReference()
        {
        }

    }
}