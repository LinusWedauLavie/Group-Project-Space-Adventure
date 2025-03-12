using UnityEngine;

public class MedbayCommie : MonoBehaviour
{
    public Sprite full;
    public Sprite empty;
    SaveRoomStates saveRoomStates;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item neededItem;
    [HideInInspector]public UnityEngine.UI.Image buttonImage;
    public MedbayScan medbayScan;
    [HideInInspector]public bool hammerPlaced, sicklePlaced; 

    void Start()
    {

        Debug.Log("du bist nur einmal da");
        saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        if(saveRoomStates.medbayCommieCount != 0)
        {

            if(full == null)
            {
                Debug.Log("hilfe");
            } 
                Debug.Log(saveRoomStates.hammerPlaced);
            if(saveRoomStates.hammerPlaced)
            {
                Debug.Log("HAmmer");
                buttonImage.sprite = full;
            }
            if(saveRoomStates.sicklePlaced)
            {
                Debug.Log("Sichel");
                buttonImage.sprite = full;
            }
            medbayScan.communism = saveRoomStates.medbayCommieCount;

        }
        else
        {
            buttonImage = GetComponent<UnityEngine.UI.Image>();
            buttonImage.sprite = empty;
        }
    }
    void Update()
    {
        currentItem = inventoryManager.GetSelectedItem(false);
    }
    public void OnButtonPressRecipe()
    {           
        if (neededItem == currentItem )      
        {
            if(neededItem.name == "Hammer")
            {
                hammerPlaced = true;
                saveRoomStates.hammerPlaced = hammerPlaced;
                buttonImage.sprite = full;
            }else if(neededItem.name == "Sichel")
            {
                sicklePlaced = true;
                saveRoomStates.sicklePlaced = sicklePlaced;
                buttonImage.sprite = full;
            }

            InventoryManager.instance.GetSelectedItem(true);      
            medbayScan.communism += 1;

            saveRoomStates.GetRoomState();
        }
    }
}
