#nullable enable

namespace BytePlusSeedSpeech.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BytePlusSeedSpeech.AudioFormat?>
    {
        /// <inheritdoc />
        public override global::BytePlusSeedSpeech.AudioFormat? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::BytePlusSeedSpeech.AudioFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BytePlusSeedSpeech.AudioFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BytePlusSeedSpeech.AudioFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BytePlusSeedSpeech.AudioFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::BytePlusSeedSpeech.AudioFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
