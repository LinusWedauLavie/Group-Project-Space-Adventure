using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public UnityEngine.UI.Image image; 
    [HideInInspector] public Item item;

    private MoveObjectLeft ableToPickUps;
    public GameObject ableToPickUp;

    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;
    void Start()
    {
        ableToPickUps = ableToPickUp.GetComponent<MoveObjectLeft>();

    }
    public void AddItem(Item item)
    {
        if(ableToPickUps == true)
        {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if(itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return;
            }
        }
        }
    }
    void SpawnNewItem(Item item, InventorySlot slot)
    {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }
}
