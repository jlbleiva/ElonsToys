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
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
