using System;

public class ArmorPolicy : IDefensePolicy
{
    private readonly int _value;

    public ArmorPolicy() : this(0)
    { }

    public ArmorPolicy(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("defence value must be > 0");

        _value = value;
    }

    public int Defense(int damage)
    {
        return damage - _value;
    }
}
