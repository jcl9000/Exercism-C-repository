public class Player
{
    Random random = new Random();
    public int RollDie()
    {
        return random.Next(1,19);
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        return random.NextDouble() * 100;
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
