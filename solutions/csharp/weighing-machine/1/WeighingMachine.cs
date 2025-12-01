class WeighingMachine
{
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
    
    public int Precision { get; }

    private double _weight;
    public double Weight 
    { 
        get {return _weight;}
        set {_weight = value > 0 ? value : throw new ArgumentOutOfRangeException("");}
    }

    private string _displayWeight;
    public string DisplayWeight
    {
        get 
        {
            _displayWeight = $"{Math.Round(_weight - TareAdjustment, Precision).ToString($"F{Precision}")} kg";
            return _displayWeight;
        }
        set {_displayWeight = $"{value} kg";}
    }
    
    public double TareAdjustment { get; set; } = 5.0;
}
