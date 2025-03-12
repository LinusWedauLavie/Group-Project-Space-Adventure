using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;

    //Room bool's damit die räume nur eine Aufgabe ihren State laden
    public bool cryoCompletedSave, cabineCompletedSave;

    //Für Cryo
    public bool firstLoad = true;

    //Collectables
    public bool coinCryoCollected, coinCanteenCollected, coinLabCollected, coinMedbayCollected; //mehr coins hier))
    public int memoryCards; //Menge an karten die gesammelt wurden
    public bool cabinesMemCardCollected, canteenMemoryCardCollected, labMemCardCollected, medbayMemCardCollected; //memorycards 
    public bool sickleCollected,sicklePlaced, hammerCollected, hammerPlaced, scanDone; //Medbay minigame 
    public int medbayCommieCount; //Medbay sichel und hammer zähler
    public bool cabinesMapCollected, medbayMapCollected, theStorageMapCollected; //lab minigame items


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

    public void GetRoomState()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case "Bridge":
                memoryCards = FindAnyObjectByType<Ki_MemoryCard>().memoryCards;
            break;
            case "Cabines":
                cabineCompletedSave = FindAnyObjectByType<SimonSays>().done;
            break;
            case "Canteen":

            break;
            case "Cryo":
                cryoCompletedSave = FindAnyObjectByType<MoveObjectLeft>().hasMoved;
                firstLoad = false;
            break;
            case "Hangar":

            break;
            case "Lab":

            break;
            case "Medbay":
                medbayCommieCount = FindAnyObjectByType<MedbayScan>().communism;
                scanDone = FindAnyObjectByType<MedbayScan>().scanDone;
                hammerPlaced = FindAnyObjectByType<MedbayCommie>().hammerPlaced;
                sicklePlaced = FindAnyObjectByType<MedbayCommie>().sicklePlaced;

            break;
            case "TheStorage":

            break;
            default:
                Debug.Log("Saveroomstate konnte den Raum nicht speichern, weil der Raum nicht gefunden wurde!");
            break;
        }
    }
}
