class RemoteControlCar
{

    private int _distanceDriven = 0;
    private int _batteryLevel = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => _batteryLevel < 1 ? "Battery empty" : $"Battery at {_batteryLevel}%";

    public void Drive()
    {
        if (_batteryLevel > 0)
        {
            _distanceDriven += 20;
            _batteryLevel -= 1;
        }
    }
}
