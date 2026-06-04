public static class ScrabbleScore
{
    public static int Score(string input)
    {
        string upper = input.ToUpper();
        int score = 0;
            
        string[] one = ["A","E","I","O","U","L","N","R","S","T"];
        string[] two = ["D","G"];
        string[] three = ["B","C","M","P"];
        string[] four = ["F","H","V","W","Y"];
        string[] five = ["K"];
        string[] eight = ["J","X"];
        string[] ten = ["Q","Z"];

        foreach(char letter in upper){
            for (int i = 0; i < one.Length ;i++){
                if(letter.ToString() == one[i]){
                    score++;
                }
            }
            for (int i = 0; i < two.Length ;i++){
                if(letter.ToString() == two[i]){
                    score = score + 2;
                }
            }
            for (int i = 0; i < three.Length ;i++){
                if(letter.ToString() == three[i]){
                    score = score + 3;
                }
            }
            for (int i = 0; i < four.Length ;i++){
                if(letter.ToString() == four[i]){
                    score = score + 4;
                }
            }
            for (int i = 0; i < five.Length ;i++){
                if(letter.ToString() == five[i]){
                    score = score + 5;
                }
            }
            for (int i = 0; i < eight.Length ;i++){
                if(letter.ToString() == eight[i]){
                    score = score + 8;
                }
            }
            for (int i = 0; i < ten.Length ;i++){
                if(letter.ToString() == ten[i]){
                    score = score + 10;
                }
            }
            
        }

        return score;
        
        throw new NotImplementedException("You need to implement this method.");
    }
}

