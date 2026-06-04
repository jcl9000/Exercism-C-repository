static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0){
            return 0;
        }
        else if (speed >= 1 && speed <=4){
            return 1;
        }
        else if (speed >=5 && speed <=8){
            return 0.9;
        }
        else if (speed == 9){
            return 0.8;
        }
        else if (speed == 10){
            return 0.77;
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        if(speed == 0){
            double rate = 0;
            return rate;
        }
        else if (speed >= 1 && speed <=4){
            double rate = speed * 221;
            return rate;
        }
        else if (speed >=5 && speed <=8){
            double rate = (speed * 221) * 0.9;
            return rate;
        }
        else if (speed == 9){
            double rate = (speed *221) *0.8;
            return rate;
        }
        else if (speed == 10){
            double rate = (speed*221)*0.77;
            return rate;
        }
        
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        if(speed == 0){
            double rate = 0;
            return (int) (rate /  60);
        }
        else if (speed >= 1 && speed <=4){
            double rate = speed * 221;
            return (int) (rate /  60);
        }
        else if (speed >=5 && speed <=8){
            double rate = (speed * 221) * 0.9;
            return (int) (rate /  60);
        }
        else if (speed == 9){
            double rate = (speed *221) *0.8;
            return (int) (rate /  60);
        }
        else if (speed == 10){
            double rate = (speed*221)*0.77;
            return (int) (rate /  60);
        }
        
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
