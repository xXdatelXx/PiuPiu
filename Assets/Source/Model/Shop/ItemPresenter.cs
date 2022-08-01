using System;
using UnityEngine;

public class ItemPresenter : MonoBehaviour
{
    private Item _item;
    private IShop _shop;

    public void Init(Item item, IShop shop)
    {
        _item = item ?? throw new ArgumentNullException("item == null");
        _shop = shop ?? throw new ArgumentNullException("shop == null");
    }

    public void Buy()
    {
        if (_item == null)
            return;

        _shop.Buy(_item.Kind);
    }
}
