using System.Net;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LabMiniGame : MonoBehaviour
{
    public Sprite empty;
    public Sprite oneLayer;
    public Sprite oneLayerone;
    public Sprite oneLayertwo;
    public Sprite twoLayers;
    public Sprite twoLayersone;
    public Sprite full;
    int level = 0;
    UnityEngine.UI.Image buttonImage;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item[] neededItem;
    public bool rightSolution; 

    void Start()
    {
        buttonImage = GetComponent<UnityEngine.UI.Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }
    void Update()
    {
        if (inventoryManager == null)
        {
            inventoryManager = FindAnyObjectByType<InventoryManager>();
        }

        if(level == 0)
        {   
            buttonImage.sprite = empty; 
        }
        else if (level == 1)
        {   
            buttonImage.sprite = oneLayer; 
        }
        else if (level == 2)
        {   
            buttonImage.sprite = oneLayerone; 
        }
        else if (level == 3)
        {   
            buttonImage.sprite = oneLayertwo; 
        }
        else if (level == 4)
        {   
            buttonImage.sprite = twoLayers; 
        }
        else if (level == 5)
        {   
            buttonImage.sprite = twoLayers; 
        }
        else if (level == 6)
        {   
            buttonImage.sprite = full; 
            rightSolution = true;
        }        
    }

    public void OnButtonPress()
    {         
        currentItem = InventoryManager.instance.GetSelectedItem(false);
        if (neededItem[level] == currentItem )      
        {
            InventoryManager.instance.GetSelectedItem(true);
            level += 1;
        }
        else if (neededItem[level] != currentItem )      
        {
            level = 0;
        }        
    }
   
}
