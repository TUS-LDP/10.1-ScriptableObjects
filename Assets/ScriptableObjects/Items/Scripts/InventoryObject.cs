using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Default
}

[CreateAssetMenu(fileName = "New Default Item", menuName = "Inventory System/Items/Default")]
public class InventoryObject : ScriptableObject
{
    public Sprite UIImage;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;

    public void Awake()
    {
        type = ItemType.Default;
    }
}
