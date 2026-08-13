
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    /// Output audio configuration.
    /// </summary>
    public sealed partial class AudioConfig
    {
        /// <summary>
        /// Output audio encoding. Defaults to wav.<br/>
        /// Default Value: wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BytePlusSeedSpeech.JsonConverters.AudioFormatJsonConverter))]
        public global::BytePlusSeedSpeech.AudioFormat? Format { get; set; }

        /// <summary>
        /// Output sample rate in hertz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Speech rate. 100 is 2x speed and -50 is 0.5x speed.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_rate")]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// Volume adjustment. 100 is 2x and -50 is 0.5x volume.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_rate")]
        public int? LoudnessRate { get; set; }

        /// <summary>
        /// Pitch adjustment.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch_rate")]
        public int? PitchRate { get; set; }

        /// <summary>
        /// Include utterance- and word-level timestamps in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_subtitle")]
        public bool? EnableSubtitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        /// <param name="format">
        /// Output audio encoding. Defaults to wav.<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="sampleRate">
        /// Output sample rate in hertz.
        /// </param>
        /// <param name="speechRate">
        /// Speech rate. 100 is 2x speed and -50 is 0.5x speed.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="loudnessRate">
        /// Volume adjustment. 100 is 2x and -50 is 0.5x volume.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pitchRate">
        /// Pitch adjustment.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="enableSubtitle">
        /// Include utterance- and word-level timestamps in the response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioConfig(
            global::BytePlusSeedSpeech.AudioFormat? format,
            int? sampleRate,
            int? speechRate,
            int? loudnessRate,
            int? pitchRate,
            bool? enableSubtitle)
        {
            this.Format = format;
            this.SampleRate = sampleRate;
            this.SpeechRate = speechRate;
            this.LoudnessRate = loudnessRate;
            this.PitchRate = pitchRate;
            this.EnableSubtitle = enableSubtitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        public AudioConfig()
        {
        }

    }
}