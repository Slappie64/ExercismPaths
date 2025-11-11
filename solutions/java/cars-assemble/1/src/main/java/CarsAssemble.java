public class CarsAssemble {
    private int _carsPerHour = 221;
    
    public double productionRatePerHour(int speed) 
    {
        if (speed == 0) { return 0; }
        if (speed > 0 && speed <= 4) { return _carsPerHour * speed; }
        if (speed > 4 && speed <= 8) { return (_carsPerHour * speed) * 0.9; }
        if (speed == 9) { return (_carsPerHour * speed) * 0.8; }
        if (speed == 10) { return (_carsPerHour * speed) * 0.77; }
        return 0;
    }

    public int workingItemsPerMinute(int speed) {
        return (int)productionRatePerHour(speed) / 60;
    }
}
