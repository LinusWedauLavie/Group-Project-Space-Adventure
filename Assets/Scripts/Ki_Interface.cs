using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Ki_Interface : MonoBehaviour, IPointerClickHandler
{
    public GameObject kiCanvas;
    bool clicked = false;
    public Item item;
    public Item currentItem;
    public Button button;
    SaveRoomStates saveRoomStates;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KiInterfaceButtonClick(bool activate)
    {
        kiCanvas.SetActive(activate);
        //TODO machen das sich das Interface öffnet
    }

        public void OnPointerClick(PointerEventData eventData)
    {
        if (clicked == false && NecessaryItemCheck.instance.neededItem == currentItem && saveRoomStates.cryoCompletedSave == false)
        {
            clicked = true;
            button.interactable = true;
            //doorUnlocked = true;
            InventoryManager.instance.GetSelectedItem(true);
        }
    }

    public void MemoryCardButtonClick(string buttonName)
    {
        switch(buttonName)
        {
            case "Memory Card 1":
                Debug.Log("test33r24");
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 2":
                Debug.Log("test2398048907235");
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 3":
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 4":
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 5":
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 6":
                //TODO machen das man den Text sieht
            break;
            
        }
    }
}
