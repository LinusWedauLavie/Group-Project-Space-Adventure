using UnityEngine;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;

    public bool SaveCryroCompleted;
    public bool coinCryoCollected;

    public bool SaveCabineCompleted;


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
        SaveCabineCompleted = FindAnyObjectByType<SimonSays>().done;
    }
    public void GetCryoRoomState()
    {
        //hasMovedSave = GetComponent<MoveObjectLeft>().MoveObjectLeft.hasMoved;
        SaveCryroCompleted = FindAnyObjectByType<MoveObjectLeft>().hasMoved;
        
    }
}
