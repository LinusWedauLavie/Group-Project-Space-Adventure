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
    public AudioSource audioSource;
    void Start()
    {
        buttonImage = GetComponent<Image>();
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {      
        buttonImage.sprite = pressedImage;
        doorOpen = true;
        SceneManager.LoadScene(sceneName);
        audioSource.Play();
              
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonImage.sprite = pressedImage;  
        audioSource.Play();
     
    }
        public void OnPointerExit(PointerEventData eventData)
    {
        if (doorOpen == false)
        {
            buttonImage.sprite = normalImage;
            

        }        
    }
}
