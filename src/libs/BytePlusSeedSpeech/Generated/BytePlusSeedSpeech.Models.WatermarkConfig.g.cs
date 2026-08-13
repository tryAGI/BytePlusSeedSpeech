
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    /// Explicit and implicit audio watermark configuration.
    /// </summary>
    public sealed partial class WatermarkConfig
    {
        /// <summary>
        /// Add an audio rhythm marker at the end of the generated audio.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aigc_watermark")]
        public bool? AigcWatermark { get; set; }

        /// <summary>
        /// Metadata embedded in the synthesized audio header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aigc_metadata")]
        public global::BytePlusSeedSpeech.AigcMetadata? AigcMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkConfig" /> class.
        /// </summary>
        /// <param name="aigcWatermark">
        /// Add an audio rhythm marker at the end of the generated audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="aigcMetadata">
        /// Metadata embedded in the synthesized audio header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkConfig(
            bool? aigcWatermark,
            global::BytePlusSeedSpeech.AigcMetadata? aigcMetadata)
        {
            this.AigcWatermark = aigcWatermark;
            this.AigcMetadata = aigcMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkConfig" /> class.
        /// </summary>
        public WatermarkConfig()
        {
        }

    }
}