using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorOpenLocked : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    SaveRoomStates saveRoomStates;
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

        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        if (saveRoomStates.SaveCryroCompleted)
        {
            cableMiniGame.rightSolution=true;
        }
    }

     public void OnPointerClick(PointerEventData eventData)
    {
        if (cableMiniGame.rightSolution == true)
        {
            FindAnyObjectByType<SaveRoomStates>().GetCryoRoomState();
            buttonImage.sprite = pressedImage;
            doorOpen = true;
            audioSource.Play();
            SceneManager.LoadScene(sceneName);

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (cableMiniGame.rightSolution == true)
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
