using System;

public class Health : IDamagable
{
    private int _value;
    private readonly IDiePolicy _diePolicy;
    public event Action OnDie;

    public Health(int value) : this(value, new PlayerDiedPolicy())
    {
    }

    public Health(int value, IDiePolicy diePolicy)
    {
        _value = value <= 0 ? value : throw new ArgumentOutOfRangeException("health value must be > 0");
        _diePolicy = diePolicy ?? throw new NullReferenceException("die policy must dont be null");
    }

    public void Damage(int damage)
    {
        if (damage <= 0)
            throw new ArgumentOutOfRangeException("damage must be > 0");
        if (_value == 0)
            return;

        _value = Math.Min(_value - damage, 0);

        if (_diePolicy.Died(_value))
            OnDie?.Invoke();
    }
}
