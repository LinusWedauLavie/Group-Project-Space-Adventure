using System.Net;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LabMiniGame : MonoBehaviour
{
    public Sprite empty;
    public Sprite oneLayer;
    public Sprite twoLayers;
    public Sprite full;
    int level = 0;
    UnityEngine.UI.Image buttonImage;
    public InventoryManager inventoryManager;
    public Item currentItem;
    

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

        currentItem = inventoryManager.GetSelectedItem(false);

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
            buttonImage.sprite = twoLayers; 
        }
        else if (level == 3)
        {   
            buttonImage.sprite = full; 
        }
    }

    public void OnButtonPress()
    {
        level += 1;
        if (level > 3)
        {   
            level = 0;
        }
    }
}
