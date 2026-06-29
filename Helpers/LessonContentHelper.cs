namespace Godot_Learning_WebSite.Helpers;

public static class LessonContentHelper
{
    public static string FormatInline(string text)
    {
        text = System.Text.RegularExpressions.Regex.Replace(
            text, @"\*\*(.+?)\*\*", "<strong>$1</strong>");
        text = System.Text.RegularExpressions.Regex.Replace(
            text, @"\[(.+?)\]\((.+?)\)", "<a href=\"$2\" target=\"_blank\" rel=\"noopener\">$1</a>");
        text = System.Text.RegularExpressions.Regex.Replace(
            text, @"`(.+?)`", "<code class=\"inline-code\">$1</code>");
        return text;
    }

    public static string ExtractCodeBlock(string block)
    {
        var lines = block.Split('\n');
        return string.Join("\n", lines.Skip(1).TakeWhile(l => !l.TrimStart().StartsWith("```")));
    }

    public static bool IsTableSeparator(string row) =>
        !string.IsNullOrWhiteSpace(row) && row.Replace("|", "").Replace("-", "").Trim().Length == 0;
}
