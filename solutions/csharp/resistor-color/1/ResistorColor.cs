public static class ResistorColor
{
    private static string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        
    public static int ColorCode(string color)
    {
        return Array.IndexOf(colors,color);
        throw new NotImplementedException("You need to implement this method.");
    }

    public static string[] Colors()
    {
        return colors;
        throw new NotImplementedException("You need to implement this method.");
    }
}