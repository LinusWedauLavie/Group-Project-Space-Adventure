using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler, IPointerClickHandler
{

    public UnityEngine.UI.Image image; 
    public Color selectedColor, notSelectedColor;
    public int slotNumber;
    public int currentSlotNumber = -1;
    

    private void Awake()
    {
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
        Debug.Log(slotNumber);
        currentSlotNumber = slotNumber;       
       
    }


}
