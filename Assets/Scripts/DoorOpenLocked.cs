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
    public string sceneName;  
    private UnlockDoor doorUnlockeda;
    public CableMiniGame cableMiniGame;
    public AudioSource audioSource;
 
    void Start()
    {
        buttonImage = GetComponent<Image>();
        doorUnlockeda = doorUnlock.GetComponent<UnlockDoor>();
        cableMiniGame = cableMiniGame.GetComponent<CableMiniGame>();
       
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        if(cableMiniGame.rightSolution == true)
        {
            buttonImage.sprite = pressedImage;
            doorOpen = true;
            audioSource.Play();
            SceneManager.LoadScene(sceneName);
            //SceneManager.LoadScene("Test", LoadSceneMode.Additive);
            
        }       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(cableMiniGame.rightSolution == true)
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
