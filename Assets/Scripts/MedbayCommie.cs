using UnityEngine;

public class MedbayCommie : MonoBehaviour
{
    public Sprite full;
    public Sprite empty;
    SaveRoomStates saveRoomStates;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item neededItem;
    public UnityEngine.UI.Image buttonImage;
    public MedbayScan medbayScan;
     public bool hammerPlaced, sicklePlaced; //[HideInInspector]

    void Start()
    {
        saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        if (saveRoomStates.medbayCommieCount != 0)
        {
            buttonImage = GetComponent<UnityEngine.UI.Image>();

            if (saveRoomStates.hammerPlaced && this.gameObject.name == "Hammer")
            {
                buttonImage.sprite = full;
            }
            else if (saveRoomStates.sicklePlaced && this.name == "Sichel")
            {
                buttonImage.sprite = full;
            }
            else
            {
                buttonImage.sprite = empty;
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
        if (neededItem == currentItem)
        {
            if (neededItem.name == "Hammer" && this.gameObject.name=="Hammer")
            {
                hammerPlaced = true;
                saveRoomStates.hammerPlaced = true;
                buttonImage.sprite = full;
            }
            else if (neededItem.name == "Sichel" && this.gameObject.name == "Sichel")
            {
                sicklePlaced = true;
                saveRoomStates.sicklePlaced = true;
                buttonImage.sprite = full;
            }
            
            InventoryManager.instance.GetSelectedItem(true);
            medbayScan.communism += 1;

            saveRoomStates.GetRoomState();
        }
    }
}
