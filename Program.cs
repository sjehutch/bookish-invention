using System;

public class TokenCounter
{
    public static int CountTokens(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        // Estimate: 1 token ≈ 4 characters (for English text)
        int estimatedTokens = input.Length / 4;

        return estimatedTokens;
    }

    public static void Main()
    {
        string text = "This is a test sentence to estimate token count.";
        int tokenCount = CountTokens(text);

        Console.WriteLine($"Estimated token count: {tokenCount}");
    }
}