using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour
{
    public UnityEngine.UI.Image image; 
    [HideInInspector] public Item item;

    private MoveObjectLeft ableToPickUps;
    public GameObject ableToPickUp;

    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    int selectedSlot = 3;
    int number = 0;
    public ItemPickup itemPickup;
    public InventorySlot inventorySlot;
   
    void Update()
    {
        //ChangedSelectedSlot(inventorySlot.currentSlotNumber);
/*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           number += 1;
           if(number > 31)
            {
                number = 31;
            }
            ChangedSelectedSlot(number);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            number -= 1;
            if(number < 0)
            {
                number = 0;
            }
            ChangedSelectedSlot(number);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            number -= 8;
            if(number < 0)
            {
                number = 0;
            }
            ChangedSelectedSlot(number);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            number += 8;
            if(number > 31)
            {
                number = 31;
            }
            ChangedSelectedSlot(number);
        }

*/
        /*if( Input.inputString != null)
        {
            bool isNumber = int.TryParse(Input.inputString, out int number);
            if (isNumber && number > 0 && number < 32){
                ChangedSelectedSlot(number - 1) ;
            }
        }*/
    }


    public void ChangedSelectedSlot (int newValue)
    {
        if (selectedSlot >= 0)
        {
            inventorySlots[selectedSlot].Deselect();
        }

        inventorySlots[newValue].Select();
        selectedSlot = newValue;
    }
    void Start()
    {
        
    }
    
    public void AddItem(Item item)
    {
        //if(itemPickup.ableToPickUp == true)
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
        //if(itemPickup.ableToPickUp == true)
        {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
        }
    }


}
