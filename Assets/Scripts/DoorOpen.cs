using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
 
public class DoorOpen : MonoBehaviour, IPointerClickHandler,IPointerEnterHandler, IPointerExitHandler
{
    public Sprite normalImage;
    public Sprite pressedImage;
    bool doorOpen = false;
    private Image buttonImage;
 
    void Start()
    {
        buttonImage = GetComponent<Image>();
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        buttonImage.sprite = pressedImage;
        doorOpen = true;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonImage.sprite = pressedImage;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (doorOpen == false)
        {
            buttonImage.sprite = normalImage;
        }
        
    }
}
