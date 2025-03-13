using UnityEngine;
using UnityEngine.UI;

public class SimonSaysEnterButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    SaveRoomStates saveRoomStates;
    public GameObject Memorycard;
    public Button button;
    void Awake()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        if(saveRoomStates.cabineCompletedSave == true)
        {
            button.enabled = false;
        }
        if (saveRoomStates.cabineCompletedSave == true && saveRoomStates.cabinesMemCardCollected == false)
        {
          Memorycard.SetActive(true);
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
