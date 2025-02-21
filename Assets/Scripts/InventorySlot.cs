using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler, IPointerClickHandler
{
    InventoryManager inventoryManager;
    public UnityEngine.UI.Image image; 
    public Color selectedColor, notSelectedColor;
    public int slotNumber;
    

    private void Awake()
    {
        inventoryManager = FindFirstObjectByType<InventoryManager>();
        Deselect();
    }
    public void Select()
    {
        image.color = selectedColor;     
    }
    public void Deselect()
    {
        image.color = notSelectedColor;     
    }


    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag; 
            InventoryItem draggableItem = dropped.GetComponent<InventoryItem>();
            draggableItem.parentAfterDrag = transform;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {     
       inventoryManager.ChangedSelectedSlot(slotNumber);
    }


}
