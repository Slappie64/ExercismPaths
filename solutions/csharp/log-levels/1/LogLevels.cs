static class LogLine
{
    public static string Message(string logLine) => logLine.Split(":")[1].Trim();

    public static string LogLevel(string logLine)
    {
        string errorLevel = logLine.Split(":")[0].Trim();
        return string.Join("", errorLevel.Split(':', '[', ']')).ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
