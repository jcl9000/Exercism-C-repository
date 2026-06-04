public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int total = 0;
        foreach (char letter in input.ToUpper()){
            switch(letter){
                case 'A' or 'E' or 'I' or 'O' or 'U' or 'L' or 'N' or 'R' or 'S' or 'T':
                    total++;break;
                case 'D' or 'G':
                    total += 2; break;
                case 'B' or 'C' or 'M' or 'P':
                    total += 3; break;
                case 'F' or 'H' or 'V' or 'W' or 'Y':
                    total += 4; break;
                case 'K':
                    total += 5; break;
                case 'J' or 'X':
                     total += 8; break;
                case 'Q' or 'Z':
                     total += 10; break;
            }
        }
        return total;
        throw new NotImplementedException("You need to implement this method.");
    }
}