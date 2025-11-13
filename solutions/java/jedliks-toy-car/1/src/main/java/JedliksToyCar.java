public class JedliksToyCar 
{
    private int _distanceDriven = 0;
    private int _battery = 100;
    
    public static JedliksToyCar buy() 
    {
        return new JedliksToyCar();
    }

    public String distanceDisplay() 
    {
        return String.format("Driven %d meters", _distanceDriven);
    }

    public String batteryDisplay() 
    {
        if (_battery <= 1) { return "Battery empty"; }
        return String.format("Battery at %d%%", _battery);
    }

    public void drive() 
    {
        if (_battery >= 1) 
        { 
            _distanceDriven += 20;
            _battery -= 1;
        }
    }
}
