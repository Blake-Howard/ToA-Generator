using System;

public class DiceRoller
{
    Random rand;
    public DiceRoller()
    {
        rand = new Random();
    }

    public int Roll(int amount, int size)
    {
        int sum = 0;
        for (int i = 0; i < amount; i++)
        {
            sum += rand.Next(1, size + 1);
        }

        return sum;
    }

    public int Roll4()
    {
        return Roll(1, 4);
    }

    public int Roll6()
    {
        return Roll(1, 6);
    }

    public int Roll8()
    {
        return Roll(1, 8);
    }

    public int roll10()
    {
        return Roll(1, 10);
    }

    public int roll12()
    {
        return Roll(1, 12);
    }

    public int Roll20()
    {
        return Roll(1, 20);
    }

    public int Roll100()
    { 
        return Roll(1, 100);
    }
}
