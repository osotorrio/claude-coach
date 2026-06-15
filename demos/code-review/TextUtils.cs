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
        ArgumentNullException.ThrowIfNull(text);

        if (text.Length <= maxLength)
        {
            return text;
        }

        const string ellipsis = "...";

        // Guard against tiny limits where there's no room for the ellipsis.
        if (maxLength <= ellipsis.Length)
        {
            return text.Substring(0, maxLength);
        }

        // Reserve room for the ellipsis so the result stays within maxLength.
        return text.Substring(0, maxLength - ellipsis.Length) + ellipsis;
    }

    /// <summary>
    /// Returns the average word length (in characters) of the given sentence.
    /// </summary>
    public static double AverageWordLength(string sentence)
    {
        ArgumentNullException.ThrowIfNull(sentence);

        var words = sentence.Split(' ');
        var total = 0;

        for (var i = 0; i < words.Length; i++)
        {
            total += words[i].Length;
        }

        return (double)total / words.Length;
    }
}
