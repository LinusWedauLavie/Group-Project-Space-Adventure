using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;


public class Ki_MemoryCard : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item neededItem;
    public int memoryCards = 0;
    public GameObject[] cardsUsed;  
    SaveRoomStates saveRoomStates;
    void Start()
    {
        saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        
        memoryCards = saveRoomStates.memoryCards;
        for(int i = 0; i < memoryCards; i++)
        {
            cardsUsed[i].SetActive(true);
        }
    }
    void Update()
    {
        currentItem = inventoryManager.GetSelectedItem(false);
    }
    public void OnButtonPress()
    {       
        currentItem = inventoryManager.GetSelectedItem(false);
        if (neededItem == currentItem )      
        {
            inventoryManager.GetSelectedItem(true);       
            cardsUsed[memoryCards].SetActive(true);  
            memoryCards += 1;
            saveRoomStates.GetRoomState();  

        }
    }

}
