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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonImage = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(clicked == false)
        {
            buttonImage.sprite = pressedImage;            
            clicked = true;
            doorUnlocked = true;
        }       
    }
}
