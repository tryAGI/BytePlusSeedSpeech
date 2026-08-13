
#nullable enable

namespace BytePlusSeedSpeech
{
    public partial interface IBytePlusSeedSpeechClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}