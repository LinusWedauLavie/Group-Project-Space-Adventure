using UnityEngine;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;
    public bool firstLoad = true;

    public bool cryoCompletedSave;
    public bool coinCryoCollected;

    public bool cabineCompletedSave;


    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void GetCabinesRoomState()
    {
        cabineCompletedSave = FindAnyObjectByType<SimonSays>().done;
    }
    public void GetCryoRoomState()
    {
        cryoCompletedSave = FindAnyObjectByType<MoveObjectLeft>().hasMoved;
        firstLoad = false;
    }
}
