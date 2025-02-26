using UnityEngine;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;
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
    public bool hasMovedSave;
    public void GetCryoRoomStates()
    {
        //hasMovedSave = GetComponent<MoveObjectLeft>().MoveObjectLeft.hasMoved;
        hasMovedSave = FindAnyObjectByType<MoveObjectLeft>().hasMoved;
        Debug.Log(hasMovedSave);
    }
}
