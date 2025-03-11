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


        if (this.name == "Sichel") { Debug.Log("KAMERADEN AN DIE FRONT!!!"); }


        if (this.name == "CryoCoin")
        {
            if (saveRoomStates.coinCryoCollected)
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
        //
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (ableToPickUp != false)
        {
            if (this.name == "CryoCoin")
            {
                saveRoomStates.coinCryoCollected = true;
            }
            //
            Destroy(gameObject);
        }

    }

}
