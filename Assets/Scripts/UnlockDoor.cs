using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UnlockDoor : MonoBehaviour, IPointerClickHandler
{
    public Sprite normalImage;
    public Sprite pressedImage;
    private Image buttonImage;
    bool clicked = false;
    public bool doorUnlocked;
    public Item item; 
    public Item currentItem;
    public Button button;

    public InventoryManager inventoryManager ;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }
    void Update()
    {
        if(inventoryManager == null)
        {
            inventoryManager = FindAnyObjectByType<InventoryManager>();
        }

        currentItem = inventoryManager.GetSelectedItem(false);

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(clicked == false && NecessaryItemCheck.instance.neededItem == currentItem)
        { 
            buttonImage.sprite = pressedImage;            
            clicked = true;
            button.interactable = true;
            //doorUnlocked = true;
            InventoryManager.instance.GetSelectedItem(true);
        }       
    }
}
