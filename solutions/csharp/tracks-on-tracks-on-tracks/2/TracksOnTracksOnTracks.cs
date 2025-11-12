public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages() => new List<string>()
    {
        "C#",
        "Clojure",
        "Elm"
    };

    public static List<string> AddLanguage(List<string> languages, string language) => languages.Append(language).ToList();

    public static int CountLanguages(List<string> languages) => languages.Count();

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages) => languages.Reverse<string>().ToList();


    public static bool IsExciting(List<string> languages)
    {
        if (!languages.Any()) { return false; }
        return (languages[0] == "C#" || (languages[1] == "C#" && (CountLanguages(languages) >= 2 && CountLanguages(languages) <= 3)));
    }

    public static List<string> RemoveLanguage(List<string> languages, string language) => languages.Where(x => x != language).ToList();

    public static bool IsUnique(List<string> languages) => (languages.Distinct().Count() == languages.Count());
    
}
