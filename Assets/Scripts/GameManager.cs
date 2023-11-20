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
}
