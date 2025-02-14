using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class DoorOpenLocked : MonoBehaviour, IPointerClickHandler,IPointerEnterHandler, IPointerExitHandler 
{
    public Sprite normalImage;
    public Sprite pressedImage;
    public bool doorOpen = false;
    public GameObject doorUnlock;
    private Image buttonImage;
    //public Scene scene;
    public string sceneName;  
    private UnlockDoor doorUnlockeda;
    public AudioSource audioSource;
 
    void Start()
    {
        buttonImage = GetComponent<Image>();
        doorUnlockeda = doorUnlock.GetComponent<UnlockDoor>();
       
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        if(doorUnlockeda.doorUnlocked == true)
        {
            buttonImage.sprite = pressedImage;
            doorOpen = true;
            audioSource.Play();
            SceneManager.LoadScene(sceneName);
            
        }       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(doorUnlockeda.doorUnlocked == true)
        {
            buttonImage.sprite = pressedImage;
             audioSource.Play();
        }        
    }
        public void OnPointerExit(PointerEventData eventData)
    {
        if (doorOpen == false)
        {
            buttonImage.sprite = normalImage;
        }        
    }
}
