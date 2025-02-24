using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickUp;

    public void PickupItem(int id)
    {
        inventoryManager.AddItem(itemsToPickUp[id]);
    }

    public void GetSelectedItem()
    {
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
