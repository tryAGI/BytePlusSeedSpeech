
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubtitleWord
    {
        /// <summary>
        /// Word start time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public int? StartTime { get; set; }

        /// <summary>
        /// Word end time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitleWord" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Word start time in milliseconds.
        /// </param>
        /// <param name="endTime">
        /// Word end time in milliseconds.
        /// </param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubtitleWord(
            int? startTime,
            int? endTime,
            string? text)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitleWord" /> class.
        /// </summary>
        public SubtitleWord()
        {
        }

    }
}