using System;

public class RandomNumberGenerator
{
    private readonly Random random;

    public RandomNumberGenerator()
    {
        random = new Random();
    }

    public int GenerateRandomNumber(int minValue, int maxValue)
    {
        return random.Next(minValue, maxValue + 1);
    }
}
