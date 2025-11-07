public class Lasagna {
    public int expectedMinutesInOven()
    {
        return 40;
    }

    public int remainingMinutesInOven(int elapsedMinutes)
    {
        return expectedMinutesInOven() - elapsedMinutes;
    }
    
    public int preparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // TODO: define the 'totalTimeInMinutes()' method
    public int totalTimeInMinutes(int layers, int timeElapsed)
    {
        return timeElapsed + preparationTimeInMinutes(layers);
    }
}
