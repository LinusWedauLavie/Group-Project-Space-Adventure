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
 
    private void Update() 
    {
        if (wireCut && wrongWireCut)
        {
            wireCut = false;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {      
        buttonImage.sprite = pressedImage;
        wireCut = true; 
        //audioSource.Play();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(wireCut == false){
        buttonImage.sprite = hoverImage; 
        } 
    }
        public void OnPointerExit(PointerEventData eventData)
    {    
        if(wireCut == false){
        buttonImage.sprite = normalImage;
        }
    }
}
