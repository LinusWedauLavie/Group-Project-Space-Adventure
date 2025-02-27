using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UnlockDoor : MonoBehaviour, IPointerClickHandler
{
    SaveRoomStates saveRoomStates;
    public Sprite normalImage;
    public Sprite pressedImage;
    private Image buttonImage;
    bool clicked = false;
    public bool doorUnlocked;
    public Item item;
    public Item currentItem;
    public Button button;

    public InventoryManager inventoryManager;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        if (saveRoomStates.SaveCryroCompleted)
        {
            buttonImage.sprite = pressedImage;
            clicked = true;
            button.interactable = true;
            Button button1 = GetComponent<Button>();
            button1.enabled = false;
        }
    }
    void Update()
    {
        if (inventoryManager == null)
        {
            inventoryManager = FindAnyObjectByType<InventoryManager>();
        }

        currentItem = inventoryManager.GetSelectedItem(false);

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clicked == false && NecessaryItemCheck.instance.neededItem == currentItem && saveRoomStates.SaveCryroCompleted == false)
        {
            buttonImage.sprite = pressedImage;
            clicked = true;
            button.interactable = true;
            //doorUnlocked = true;
            InventoryManager.instance.GetSelectedItem(true);
        }
    }
}
