using System;
using UnityEngine;
using UnityEngine.UI;

public class Ki_Interface : MonoBehaviour
{
    public GameObject kiCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("tgesgfgtz");
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

    public void MemoryCardButtonClick(string buttonName)
    {
        switch(buttonName)
        {
            case "Memory Card 1":
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 2":
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
