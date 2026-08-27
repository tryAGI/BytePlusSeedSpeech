
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Subtitle
    {
        /// <summary>
        /// Full subtitle text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        public global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.SubtitleSentence>? Sentences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Subtitle" /> class.
        /// </summary>
        /// <param name="text">
        /// Full subtitle text.
        /// </param>
        /// <param name="sentences"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Subtitle(
            string? text,
            global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.SubtitleSentence>? sentences)
        {
            this.Text = text;
            this.Sentences = sentences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subtitle" /> class.
        /// </summary>
        public Subtitle()
        {
        }

    }
}