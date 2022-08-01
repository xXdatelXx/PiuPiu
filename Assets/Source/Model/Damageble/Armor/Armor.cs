using System;
using UnityEngine;

public abstract class Armor : MonoBehaviour, IDamagable
{
    private IDamagable _decorated;
    private IDefensePolicy _defensePolicy;

    private void Awake()
    {
        _defensePolicy = new ArmorPolicy();
    }

    public void Init(IDamagable decorated)
    {
        Init(decorated, new ArmorPolicy());
    }

    public void Init(IDamagable decorated, IDefensePolicy defensePolicy)
    {
        _decorated = decorated ?? throw new ArgumentNullException("decorated == null");
        Update(defensePolicy);
    }

    public void Update(IDefensePolicy defensePolicy)
    {
        _defensePolicy = defensePolicy ?? throw new ArgumentOutOfRangeException("defenseStrategy == 0");
    }

    public void Damage(int damage)
    {
        if (_decorated == null)
            return;

        damage -= _defensePolicy.Defense(damage);

        if (damage > 0)
            _decorated.Damage(damage);
    }
}
