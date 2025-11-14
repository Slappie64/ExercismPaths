 public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) =>  shirtNum switch
    {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => "UNKNOWN"
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        String announcement => $"{announcement}",
        int _ => $"There are {report} supporters at the match.",
        Foul foul => "The referee deemed a foul.",
        Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
        Incident _ => "An incident happened.",
        Manager manager => manager.Club != null ? $"{manager.Name} ({manager.Club})" : $"{manager.Name}",
        _ => ""
    };
}
