namespace BytePlusSeedSpeech.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BytePlusSeedSpeechClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BYTEPLUSSEEDSPEECH_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BYTEPLUSSEEDSPEECH_API_KEY environment variable is not found.");

        return new BytePlusSeedSpeechClient(apiKey);
    }
}
