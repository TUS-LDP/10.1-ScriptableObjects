using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemPickup : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.tag == "InventoryItem")
        {
            InventoryObject theItemSO = other.gameObject.GetComponent<InventoryItem>().inventoryScriptableObject;
            GameManager.Instance.inventoryList.Add(theItemSO);
            Destroy(other.gameObject);
        }
    }
}
