using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Medicine
}

[CreateAssetMenu(fileName = "New-Default-Item", menuName ="Inventory System/Items/Default")]
public class InventoryObject : ScriptableObject
{
    public ItemType type;
    public Sprite UIImage;
    [TextArea(15, 20)]
    public string description;
    public int quantity;
}
