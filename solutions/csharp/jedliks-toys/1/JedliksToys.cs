class RemoteControlCar
{
    public int distance = 0;
    public int battery = 100;

    public void Drive()
    {
        if(battery > 0){
               distance = distance + 20;
               battery = battery - 1;      
        }

    }
        public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if(battery == 0){
            return "Battery empty";
        }
        return $"Battery at {battery}%";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }
}
