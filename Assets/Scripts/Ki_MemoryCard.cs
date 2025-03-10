using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;


public class Ki_MemoryCard : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item neededItem;
    public int memoryCards = -1;
    public GameObject[] cardsUsed;  
    SaveRoomStates saveRoomStates;
    void Start()
    {
        saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        
        memoryCards = saveRoomStates.memoryCards;
        for(int i = 0; i <= memoryCards; i++)
        {
            cardsUsed[memoryCards].SetActive(true);
        }
    }


    void Update()
    {
        
    }
    public void OnButtonPress()
    {
       
        currentItem = inventoryManager.GetSelectedItem(false);
        if (neededItem == currentItem )      
        {
            inventoryManager.GetSelectedItem(true);       
            memoryCards += 1;
            cardsUsed[memoryCards].SetActive(true);  
            saveRoomStates.GetBridgeState();  

        }
    }

}
