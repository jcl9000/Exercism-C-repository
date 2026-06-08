class BirdCount
{
    private int[] birdsPerDay;
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
        
    }

    public static int[] LastWeek()
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool containsZero = false;
        foreach(int count in birdsPerDay){
            if (count == 0){
                containsZero = true;
            }
        }
        return containsZero;
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for(int i = 0; i<numberOfDays;i++){
            count = count + birdsPerDay[i];
        }
        return count;
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int day in birdsPerDay){
            if(day >=5){
                busyDays++;
            }
        }
        return busyDays;
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
