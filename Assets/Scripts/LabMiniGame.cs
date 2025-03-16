using UnityEngine;

public class LabMiniGame : MonoBehaviour
{
    SaveRoomStates saveRoomStates;
    public Sprite empty;
    public Sprite oneLayer;
    public Sprite oneLayerone;
    public Sprite oneLayertwo;
    public Sprite twoLayers;
    public Sprite twoLayersone;
    public Sprite full;
    public int level = 0;
    UnityEngine.UI.Image buttonImage;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item[] neededItem;
    public bool rightSolution; 
    public GameObject strengthDrink;
    public GameObject miniGameButton; 

    void Start()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        buttonImage = GetComponent<UnityEngine.UI.Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        if(saveRoomStates.labLevel != 0 || saveRoomStates.LabMiniGameRigthSolution)
        {
            level = saveRoomStates.labLevel;
            rightSolution = saveRoomStates.LabMiniGameRigthSolution; 
        }
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
            buttonImage.sprite = twoLayersone; 
        }
        else if (level == 6)
        {   
            buttonImage.sprite = full; 
            rightSolution = true;
            if (saveRoomStates.pickedUpPotion == false)
            {
                strengthDrink.SetActive(true);
            }
            else
            {
                buttonImage.sprite = empty;
            }
            miniGameButton.SetActive(false);
            saveRoomStates.GetRoomState();
        }        
    }

    public void OnButtonPress()
    {         
        currentItem = InventoryManager.instance.GetSelectedItem(false);
        if (level < 6) {
        if (neededItem[level] == currentItem)
            {
                InventoryManager.instance.GetSelectedItem(false);
                if (level != 6) { level += 1; }
            }
            else if (neededItem[level] != currentItem)
            {
                level = 0;
            }
            saveRoomStates.GetRoomState();
        }
    }
   
}
