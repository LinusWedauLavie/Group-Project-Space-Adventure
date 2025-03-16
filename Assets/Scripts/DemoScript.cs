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
        if (this.name == "HangarsDemoSpawn")
        {
            if (id == 1)
            {
                SaveRoomStates saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
                if (saveRoomStates.StormEPlanetMundspülung == 0)
                { return; }
            }
            else if (id == 2)
            {
                SaveRoomStates saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
                if (saveRoomStates.VerfluchterTerranPlanetTerraSchlangenGift == 0)
                { return; }
            }
            else if (id == 3)
            {
                SaveRoomStates saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
                if (saveRoomStates.LavaeaterPlanetZitronensäure == 0)
                { return; }
            }
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
            //Debug.Log(recievedItem);
        }
        else
        {
            //Debug.Log("No Item");
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
            //Debug.Log("Used" + recievedItem);
        }
        else
        {
            //Debug.Log("No Item used");
        }
    }

}
