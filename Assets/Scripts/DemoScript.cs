using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickUp;

    public void PickupItem(int id)
    {
        if (inventoryManager == null)
        {
            inventoryManager = FindFirstObjectByType<InventoryManager>();
        }
        inventoryManager.AddItem(itemsToPickUp[id]);
    }

    public void GetSelectedItem()
    {
        if (inventoryManager == null)
        {
            inventoryManager = FindFirstObjectByType<InventoryManager>();
        }
        Item recievedItem = inventoryManager.GetSelectedItem(false);
        if (recievedItem != null)
        {
            Debug.Log(recievedItem);
        }
        else
        {
            Debug.Log("No Item");
        }
    }

    public void UseSelectedItem()
    {
        if (inventoryManager == null)
        {
            inventoryManager = FindFirstObjectByType<InventoryManager>();
        }
        Item recievedItem = inventoryManager.GetSelectedItem(true);
        if (recievedItem != null)
        {
            Debug.Log("Used" + recievedItem);
        }
        else
        {
            Debug.Log("No Item used");
        }
    }

}
