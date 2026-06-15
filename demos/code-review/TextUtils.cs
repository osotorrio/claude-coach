namespace CoachDemo;

/// <summary>
/// Small text helpers for the CLI tool — the kind of thing /code-review should vet.
/// </summary>
public static class TextUtils
{
    /// <summary>
    /// Truncates <paramref name="text"/> to <paramref name="maxLength"/> characters,
    /// appending an ellipsis when it was shortened.
    /// </summary>
    public static string Truncate(string text, int maxLength)
    {
        if (text.Length <= maxLength)
        {
            return text;
        }

        // Take maxLength chars then add "..." on top.
        return text.Substring(0, maxLength) + "...";
    }

    /// <summary>
    /// Returns the average word length (in characters) of the given sentence.
    /// </summary>
    public static double AverageWordLength(string sentence)
    {
        var words = sentence.Split(' ');
        var total = 0;

        for (var i = 0; i <= words.Length; i++)
        {
            total += words[i].Length;
        }

        return total / words.Length;
    }
}
