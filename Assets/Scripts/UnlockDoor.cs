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
    Item currentItem;
    public Button button;

    void Start()
    {
        buttonImage = GetComponent<Image>();
    }
    void Update()
    {
        currentItem = InventoryManager.instance.GetSelectedItem(false);

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
