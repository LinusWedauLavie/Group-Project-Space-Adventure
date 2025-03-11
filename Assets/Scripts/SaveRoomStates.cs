using UnityEngine;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;
    //Bridge
    public int memoryCards;
    //Cryo
    public bool firstLoad = true;
    public bool cryoCompletedSave;
    public bool coinCryoCollected, coinCanteenCollected;
    //Cabine
    public bool cabineCompletedSave;

    public bool sickleCollected, hammerCollected;


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

    public void GetBridgeState()
    {
        memoryCards = FindAnyObjectByType<Ki_MemoryCard>().memoryCards;
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
