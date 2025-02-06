using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class DoorOpen : MonoBehaviour, IPointerClickHandler,IPointerEnterHandler, IPointerExitHandler 
{
    public Sprite normalImage;
    public Sprite pressedImage;
    public bool doorOpen = false;
    private Image buttonImage;
    //public Scene scene;
    public string sceneName;
 
    void Start()
    {
        buttonImage = GetComponent<Image>();
        //scene = GetComponent<Scene>();
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        buttonImage.sprite = pressedImage;
        doorOpen = true;
        SceneManager.LoadScene(sceneName);
        
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
