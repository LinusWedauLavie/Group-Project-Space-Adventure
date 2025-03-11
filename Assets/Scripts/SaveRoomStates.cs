using UnityEngine;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;

    //Cryo
    public bool firstLoad = true;
    public bool cryoCompletedSave;

    //Cabine
    public bool cabineCompletedSave;

    //Collectables
    public bool coinCryoCollected, coinCanteenCollected, coinLabCollected, coinMedbayCollected; //mehr coins hier))
    public int memoryCards; //Menge an karten die gesammelt wurden??
    public bool cabinesMemCardCollected, canteenMemoryCardCollected, labMemCardCollected, medbayMemCardCollected; //mehr mem cards hier??
    public bool sickleCollected, hammerCollected; //mehr items hier??
    public bool cabinesMapCollected, medbayMapCollected, theStorageMapCollected; //map pieces


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
