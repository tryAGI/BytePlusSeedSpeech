
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace BytePlusSeedSpeech
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::BytePlusSeedSpeech.JsonConverters.AudioFormatJsonConverter),

            typeof(global::BytePlusSeedSpeech.JsonConverters.AudioFormatNullableJsonConverter),

            typeof(global::BytePlusSeedSpeech.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.CreateAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.AudioReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.AudioReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.AudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.WatermarkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.AudioFormat), TypeInfoPropertyName = "AudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.AigcMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.CreateAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.Subtitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.SubtitleSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.SubtitleSentence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BytePlusSeedSpeech.SubtitleWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusSeedSpeech.SubtitleWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BytePlusSeedSpeech.AudioReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BytePlusSeedSpeech.SubtitleSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BytePlusSeedSpeech.SubtitleWord>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}