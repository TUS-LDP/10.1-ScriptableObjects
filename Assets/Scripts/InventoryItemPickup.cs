using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryItemPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "InventoryItem")
        {
            Debug.Log("Hit an inventory item");
            InventoryItem item = hit.gameObject.GetComponent<InventoryItem>();
            GameManager.instance.AddInventroyItem(item.inventoryAsset);

            Destroy(item.gameObject);
        }
    }

}