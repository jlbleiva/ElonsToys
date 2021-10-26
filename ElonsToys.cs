using System;

class RemoteControlCar

{
   
    private int _totalDistance;
    private int _actualBattery;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public RemoteControlCar()
    {
        _totalDistance = 0;
        _actualBattery = 100;
    }
    public RemoteControlCar(int distance, int battery)
    {
        _totalDistance = distance;
        _actualBattery = battery;
    }

    public string DistanceDisplay()
    {
        
        if (_totalDistance == 0) return "Driven 0 meters";
        return string.Format("Driven {0} meters",_totalDistance);
    }

    public string BatteryDisplay()
    {
        if (_actualBattery == 100) return "Battery at 100%";
        if (_actualBattery == 0) return "Battery empty";
        return string.Format("Battery at {0}%", _actualBattery);
    }

    public void Drive()
    {
        if (_actualBattery > 0)
        {
            _totalDistance += 20;
            _actualBattery -= 1;
        }
    }
}
