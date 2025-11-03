static class AssemblyLine
{

    public static double SuccessRate(int speed) => speed switch
    {
        10 => 0.77,
        9 => 0.8,
        8 or 7 or 6 or 5 => 0.9,
        4 or 3 or 2 or 1 => 1,
        _ => 0
        
    };

    public static double ProductionRatePerHour(int speed) => (speed * 221) * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}
