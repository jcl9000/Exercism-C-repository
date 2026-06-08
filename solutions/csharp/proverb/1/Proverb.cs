public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var list = new List<string>();
        for(int i = 0;i<subjects.Length;i++){
            if(i != subjects.Length - 1){
                string finalText = "For want of a " + subjects[i] + " the " + subjects[i+1] + " was lost.";
                list.Add(finalText);
            }
            else{
                string finalText = "And all for the want of a " + subjects[0] + ".";
                list.Add(finalText);
            }

        }
        return list.ToArray();
        throw new NotImplementedException("You need to implement this method.");
    }
}