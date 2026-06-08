public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for(int i = 1 ; i<=max; i++){
            sum = sum + i;
        }
        return sum*sum;
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        for(int i = 1 ; i<=max; i++){
            int square = i * i;
            sum = sum + square;
        }
        return sum;
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int sumOfSquares = 0;
        int squareOfSums = 0;
        for(int i = 1 ; i<=max; i++){
            int square = i * i;
            sumOfSquares = sumOfSquares + square;
        }
        for(int i = 1 ; i<=max; i++){
            squareOfSums = squareOfSums + i;
        }
        int squared = squareOfSums * squareOfSums;
        return squared - sumOfSquares;
        throw new NotImplementedException("You need to implement this method.");
    }
}