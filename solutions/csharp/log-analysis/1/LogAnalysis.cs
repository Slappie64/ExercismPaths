public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delim) => str.Split(delim)[1];

    public static string SubstringBetween(this string str, string start, string end) => str.Split(end)[0].Substring(str.IndexOf(start)+start.Length);
    
    public static string Message(this string str) => str.SubstringAfter(": ");

    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}