class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0,2,5,3,7,8,4};

    public int Today() => birdsPerDay.Last();

    public void IncrementTodaysCount()
    {
        birdsPerDay[6] += 1;
    }

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds = 0;
        for (int days = 0; days < numberOfDays; days++)
        {
            totalBirds += birdsPerDay[days];
        }
        return totalBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int count in birdsPerDay)
        {
            if (count >= 5) {busyDays += 1;}
        }
        return busyDays;
    }
}
