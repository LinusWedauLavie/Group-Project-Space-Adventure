using UnityEngine;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;

    public bool SaveCryroCompleted;


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
    public void GetCryoRoomStates()
    {
        //hasMovedSave = GetComponent<MoveObjectLeft>().MoveObjectLeft.hasMoved;
        SaveCryroCompleted = FindAnyObjectByType<MoveObjectLeft>().hasMoved;
        Debug.Log(SaveCryroCompleted);
    }
}
