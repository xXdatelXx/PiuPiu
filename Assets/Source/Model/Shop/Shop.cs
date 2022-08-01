using System;

public class Shop : IShop
{
    private readonly Armor _armor;

    public Shop(Armor armor)
    {
        _armor = armor ?? throw new ArgumentNullException("armor must dont be null");
    }

    public void Buy(ItemKind kind)
    {
        _armor.Update(new ArmorPolicy(10));
    }
}

public enum ItemKind
{
    Armor,
    Automat,
    Pistol,
    Rifle
}