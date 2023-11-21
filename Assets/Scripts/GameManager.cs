using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<InventoryObject> inventoryList = new List<InventoryObject>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public int AddInventoryItem(InventoryObject itemToAdd)
    {
        bool newItem = true;
        int itemCount = 0;

        for (int i = 0; i < inventoryList.Count; i++)
        {
            if (itemToAdd == inventoryList[i])
            {
                inventoryList[i].quantity++;
                itemCount = inventoryList[i].quantity;
                newItem = false;
                break;
            }
        }

        if (newItem)
        {
            itemToAdd.quantity++;
            itemCount = itemToAdd.quantity;
            inventoryList.Add(itemToAdd);
        }

        return itemCount;
    }

    private void OnDestroy()
    {
        for (int i = 0;i < inventoryList.Count;i++)
        {
            inventoryList[i].quantity = 0;
        }
    }
}
