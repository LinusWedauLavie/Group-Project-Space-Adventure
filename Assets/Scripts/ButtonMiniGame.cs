using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class ButtonMiniGame : MonoBehaviour, IPointerClickHandler ,IPointerEnterHandler, IPointerExitHandler 
{
    public Sprite normalImage;
    public Sprite pressedImage;
    public Sprite hoverImage;
    private Image buttonImage;
   // public AudioSource audioSource;
    bool wireCut = false; 
    public bool wrongWireCut = false; 
    public bool rightWire; 
    void Start()
    {
        buttonImage = GetComponent<Image>();
    }
    private int index;
    private CableMiniGame cableMiniGame;

    // This method is called by the parent script
    public void SetIndex(int i, CableMiniGame parent)
    {
        index = i;
        cableMiniGame = parent;
        // Send the index to the main script
    }
        public void OnButtonPress()
    {
        if (cableMiniGame != null)
        {
            cableMiniGame.StoreButtonIndex(index);
        }
    } 
    public void OnPointerClick(PointerEventData eventData)
    {      
        if (index == 0 || index == 1 || index == 4 || index == 5 || index == 8) 
        {
            buttonImage.sprite = pressedImage;
            wireCut = true; 
            //audioSource.Play();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(wireCut == false)
        {
            buttonImage.sprite = hoverImage; 
        } 
    }
        public void OnPointerExit(PointerEventData eventData)
    {    
        if(wireCut == false)
        {
            buttonImage.sprite = normalImage;
        }
    }
    public void Reset() 
    {
        wireCut = false;
        buttonImage.sprite = normalImage;
    }


}
