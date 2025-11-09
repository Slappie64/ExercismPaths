class RemoteControlCar
{
    private int _battery = 100;
    private int _distance;
    private int _speed;
    private int _batteryDrain;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _batteryDrain = batteryDrain;
        _speed = speed;
    }
    
    public bool BatteryDrained() => (_battery < _batteryDrain);

    public int DistanceDriven() => _distance;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _battery -= _batteryDrain;
            _distance += _speed;
        }  
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;
    
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()) {car.Drive();}
        return car.DistanceDriven() >= _distance;
    }
}
