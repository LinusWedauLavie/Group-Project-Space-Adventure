using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite normalImage;
    public Sprite pressedImage;
    public bool doorOpen = false;
    private Image buttonImage;
    //public Scene scene;
    public string sceneName;
    public AudioSource audioSource;
    public ClickCharacterMove charactermove;
    void Start()
    {
        buttonImage = GetComponent<Image>();
        charactermove = FindFirstObjectByType<ClickCharacterMove>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.name == "HangarDoor")
        {
            ProduceRessources[] producers = FindObjectsByType<ProduceRessources>(FindObjectsSortMode.None);
            foreach (ProduceRessources producer in producers)
            {
                producer.SaveRessourcesLeftOnPlanet();
            }
            RohstoffLager rohstoffLager = FindFirstObjectByType<RohstoffLager>();
            rohstoffLager.currentMiningDrones.Value = rohstoffLager.totalMiningDrones.Value;
            buttonImage.sprite = pressedImage;
            doorOpen = true;
            audioSource.Play();
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            buttonImage.sprite = pressedImage;
            doorOpen = true;
            audioSource.Play();
            SceneManager.LoadScene(sceneName);
        }
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
