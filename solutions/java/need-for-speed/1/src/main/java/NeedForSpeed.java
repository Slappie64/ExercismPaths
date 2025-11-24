class NeedForSpeed 
{

    private int _speed;
    private int _battery = 100;
    private int _batteryDrain;
    private int _distanceDriven;
    
    NeedForSpeed(int speed, int batteryDrain) 
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public boolean batteryDrained() 
    {
        return _battery < _batteryDrain;
    }

    public int distanceDriven() 
    {
        return _distanceDriven;
    }

    public void drive() 
    {
        if (!batteryDrained()) 
        { 
            _distanceDriven += _speed; 
            _battery -= _batteryDrain;
        }
    }

    public static NeedForSpeed nitro() 
    {
        return new NeedForSpeed(50, 4);
    }
}

class RaceTrack 
{

    private int _distance;
    
    RaceTrack(int distance) 
    {
        _distance = distance;
    }

    public boolean canFinishRace(NeedForSpeed car) 
    {
        while (!car.batteryDrained()) { car.drive(); }
        return car.distanceDriven() >= _distance;
        
    }
}
