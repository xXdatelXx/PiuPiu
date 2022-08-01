using UnityEngine;

[CreateAssetMenu(menuName = "ShopItem", fileName = "Item")]
public class Item : ScriptableObject
{
    [field: SerializeField] public Sprite Icon;
    [field: SerializeField] public ItemKind Kind;
}
