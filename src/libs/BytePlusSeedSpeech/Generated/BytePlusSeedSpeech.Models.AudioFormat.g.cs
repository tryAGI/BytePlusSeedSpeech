
#nullable enable

namespace BytePlusSeedSpeech
{
    /// <summary>
    /// Output audio encoding. Defaults to wav.<br/>
    /// Default Value: wav
    /// </summary>
    public enum AudioFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        OggOpus,
        /// <summary>
        ///
        /// </summary>
        Pcm,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFormat value)
        {
            return value switch
            {
                AudioFormat.Mp3 => "mp3",
                AudioFormat.OggOpus => "ogg_opus",
                AudioFormat.Pcm => "pcm",
                AudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => AudioFormat.Mp3,
                "ogg_opus" => AudioFormat.OggOpus,
                "pcm" => AudioFormat.Pcm,
                "wav" => AudioFormat.Wav,
                _ => null,
            };
        }
    }
}