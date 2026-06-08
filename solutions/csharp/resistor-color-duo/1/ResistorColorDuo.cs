public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] color = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        string output = "";
        for (int i = 0; i<2;i++){
            int value = Array.IndexOf(color,colors[i]);
            output += value.ToString();
        }
        return int.Parse(output);
        throw new NotImplementedException("You need to implement this method.");
    }
}
