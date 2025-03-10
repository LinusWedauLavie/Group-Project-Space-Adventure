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
    void Start()
    {
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }

    void Update()
    {
        currentItem = inventoryManager.GetSelectedItem(false);
        
        
    }
    public void OnButtonPress()
    {
       
        if (neededItem == currentItem )      
        {
            inventoryManager.GetSelectedItem(true);        
             memoryCards += 1;
            cardsUsed[memoryCards].SetActive(true);               
        }
    }

}
