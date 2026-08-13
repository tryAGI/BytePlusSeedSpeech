
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    /// Metadata embedded in the synthesized audio header.
    /// </summary>
    public sealed partial class AigcMetadata
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Name or code of the synthesis service provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_producer")]
        public string? ContentProducer { get; set; }

        /// <summary>
        /// Content production ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("produce_id")]
        public string? ProduceId { get; set; }

        /// <summary>
        /// Name or code of the content distribution service provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_propagator")]
        public string? ContentPropagator { get; set; }

        /// <summary>
        /// Content distribution ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagate_id")]
        public string? PropagateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AigcMetadata" /> class.
        /// </summary>
        /// <param name="enable">
        /// Default Value: false
        /// </param>
        /// <param name="contentProducer">
        /// Name or code of the synthesis service provider.
        /// </param>
        /// <param name="produceId">
        /// Content production ID.
        /// </param>
        /// <param name="contentPropagator">
        /// Name or code of the content distribution service provider.
        /// </param>
        /// <param name="propagateId">
        /// Content distribution ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AigcMetadata(
            bool? enable,
            string? contentProducer,
            string? produceId,
            string? contentPropagator,
            string? propagateId)
        {
            this.Enable = enable;
            this.ContentProducer = contentProducer;
            this.ProduceId = produceId;
            this.ContentPropagator = contentPropagator;
            this.PropagateId = propagateId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AigcMetadata" /> class.
        /// </summary>
        public AigcMetadata()
        {
        }

    }
}