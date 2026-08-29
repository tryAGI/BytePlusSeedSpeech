
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace BytePlusSeedSpeech
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.CreateAudioRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.AudioReference>? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.AudioReference? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.AudioConfig? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.WatermarkConfig? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.AudioFormat? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.AigcMetadata? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.CreateAudioResponse? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.Subtitle? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.SubtitleSentence>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.SubtitleSentence? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.SubtitleWord>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BytePlusSeedSpeech.SubtitleWord? Type17 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BytePlusSeedSpeech.AudioReference>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BytePlusSeedSpeech.SubtitleSentence>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BytePlusSeedSpeech.SubtitleWord>? ListType2 { get; set; }
    }
}