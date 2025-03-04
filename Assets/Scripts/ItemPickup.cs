using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour, IPointerClickHandler
{
    SaveRoomStates saveRoomStates;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject item;
    public bool ableToPickUp;
    //public GameObject ableToPickUp;
    //private MoveObjectLeft ableToPickUps;
    void Start()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        if (saveRoomStates.cryoCompletedSave && !CompareTag("Coin"))
        {
            gameObject.SetActive(false);
        }
        if (saveRoomStates.coinCryoCollected && CompareTag("Coin"))
        {
            gameObject.SetActive(false);
        }
        // ableToPickUps = ableToPickUp.GetComponent<MoveObjectLeft>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (ableToPickUp != false)
        {
            if (CompareTag("Coin"))
            {
                saveRoomStates.coinCryoCollected = true;
            }
            Destroy(gameObject);
        }

    }

}
