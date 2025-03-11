using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour, IPointerClickHandler
{
    SaveRoomStates saveRoomStates;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject item;
    public bool ableToPickUp;
    void Start()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();

        if (this.name == "CryoCoin")
        {
            if (saveRoomStates.coinCryoCollected)
            {
                gameObject.SetActive(false);
            }
        }
        if (this.name == "CanteenCoin")
        {
            if (saveRoomStates.coinCanteenCollected)
            {
                gameObject.SetActive(false);
            }
        }
        if (this.name == "LabCoin")
        {
            if (saveRoomStates.coinCanteenCollected)
            {
                gameObject.SetActive(false);
            }
        }
        if (this.name == "MedbayCoin")
        {
            if (saveRoomStates.coinCanteenCollected)
            {
                gameObject.SetActive(false);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Cryo")
        {
            if (saveRoomStates.cryoCompletedSave)
            {
                gameObject.SetActive(false);
            }
        }
        if (this.name == "Sichel")
        {
            if (saveRoomStates.sickleCollected)
            {
                gameObject.SetActive(false);
            }
        }
        if (this.name == "Hammer")
        {
            if (saveRoomStates.hammerCollected)
            {
                gameObject.SetActive(false);
            }
        }


        //
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (ableToPickUp != false)
        {

            switch (this.name)
            {
                case "CryoCoin":
                    saveRoomStates.coinCryoCollected = true;
                    break;
                case "Sichel":
                    saveRoomStates.sickleCollected = true;
                    break;

                    //

            }
            Destroy(gameObject);
        }

    }

}
