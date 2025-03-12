using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour, IPointerClickHandler
{
    SaveRoomStates saveRoomStates;

    public GameObject item;
    public bool ableToPickUp;
    void Start()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();

        switch (this.name)
        {
                //Mehr coins hier
            case "CryoCoin":
                if (saveRoomStates.coinCryoCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "CanteenCoin":
                if (saveRoomStates.coinCanteenCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "LabCoin":
                if (saveRoomStates.coinLabCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "MedbayCoin":
                if (saveRoomStates.coinMedbayCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
                //MedBay Items
            case "Sichel":
                if (saveRoomStates.sickleCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "Hammer":
                if (saveRoomStates.hammerCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
                //memorycards
            case "cabinesMemCard":
                if (saveRoomStates.cabinesMemCardCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "canteenMemoryCard":
                if (saveRoomStates.canteenMemoryCardCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "labMemCard":
                if (saveRoomStates.labMemCardCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "medbayMemCard":
                if (saveRoomStates.medbayMemCardCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
                //Lab minigame items
            case "cabinesMap":
                if (saveRoomStates.cabinesMapCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "medbayMap":
                if (saveRoomStates.medbayMapCollected)
                {
                    gameObject.SetActive(false);
                }
                break;
            case "theStorageMap":
                if (saveRoomStates.theStorageMapCollected)
                {
                    gameObject.SetActive(false);
                }
                break;

            default:
                if (SceneManager.GetActiveScene().name == "Cryo" && saveRoomStates.cryoCompletedSave)
                {
                    gameObject.SetActive(false);
                }
                break;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (ableToPickUp != false)
        {

            switch (this.name)
            {
                //Coins
                case "CryoCoin":
                    saveRoomStates.coinCryoCollected = true;
                    break;
                case "CanteenCoin":
                    saveRoomStates.coinCanteenCollected = true;
                    break;
                case "LabCoin":
                    saveRoomStates.coinLabCollected = true;
                    break;
                case "MedbayCoin":
                    saveRoomStates.coinMedbayCollected = true;
                    break;
                //Medbay
                case "Sichel":
                    saveRoomStates.sickleCollected = true;
                    break;
                case "Hammer":
                    saveRoomStates.hammerCollected = true;
                    break;
                //Memorycards
                case "cabinesMemCard":
                    saveRoomStates.cabinesMemCardCollected = true;
                    break;
                case "canteenMemoryCard":
                    saveRoomStates.canteenMemoryCardCollected = true;
                    break;
                case "labMemCard":
                    saveRoomStates.labMemCardCollected = true;
                    break;
                case "medbayMemCard":
                    saveRoomStates.medbayMemCardCollected = true;
                    break;
                //Lab minigame items
                case "cabinesMap":
                    saveRoomStates.cabinesMapCollected = true;
                    break;
                case "medbayMap":
                    saveRoomStates.medbayMapCollected = true;
                    break;
                case "theStorageMap":
                    saveRoomStates.theStorageMapCollected = true;
                    break;

                default:
                    break;
            }
            Destroy(gameObject);
        }

    }

}
