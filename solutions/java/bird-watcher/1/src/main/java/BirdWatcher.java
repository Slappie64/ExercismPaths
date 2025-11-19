
class BirdWatcher 
{
    private final int[] birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) 
    {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() 
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int getToday() 
    {
        return birdsPerDay[birdsPerDay.length - 1];
    }

    public void incrementTodaysCount() 
    {
        birdsPerDay[birdsPerDay.length - 1]++;
    }

    public boolean hasDayWithoutBirds() 
    {
        for(int day: birdsPerDay)
        {
            if(day == 0) { return true; }
        }
        return false;
    }

    public int getCountForFirstDays(int numberOfDays) 
    {
        int totalBirds = 0;
        
        if(numberOfDays > birdsPerDay.length) 
            {numberOfDays = 7;}
    
        for(int days = 0; days < numberOfDays; days++)
            { totalBirds += birdsPerDay[days]; }
        return totalBirds;
    }

    public int getBusyDays() 
    {
        int busyDays = 0;
        for(int day: birdsPerDay)
        {
            if(day >= 5) {busyDays++;}
        }
        return busyDays;
    }
}
