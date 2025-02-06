using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
 
public class DoorOpen : MonoBehaviour, IPointerClickHandler
{
    public Sprite normalImage;
    public Sprite pressedImage;
 
    private Image buttonImage;
 
    void Start()
    {
        buttonImage = GetComponent<Image>();
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        buttonImage.sprite = pressedImage;
    }
}