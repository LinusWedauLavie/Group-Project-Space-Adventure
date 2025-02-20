using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemAppears : MonoBehaviour, IPointerClickHandler
{
   // public SpriteRenderer sprite;
    public GameObject item; 
    public Sprite normalImage;
    public Sprite pressedImage;
    bool doorOpen = false;
    private Image buttonImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonImage = GetComponent<Image>();
       


    }
     public void OnPointerClick(PointerEventData eventData)
    {
        buttonImage.sprite = pressedImage;
        if(doorOpen == false)
        {
            doorOpen = true;
            Instantiate(item, new Vector2(item.transform.position.x ,item.transform.position.y), Quaternion.identity);
        }
    }
}
