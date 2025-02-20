using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour, IPointerClickHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject item; 
    public bool ableToPickUp;
    //public GameObject ableToPickUp;
    //private MoveObjectLeft ableToPickUps;
    void Start()
    {
       // ableToPickUps = ableToPickUp.GetComponent<MoveObjectLeft>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {        
       if(ableToPickUp)
       {
           Destroy(gameObject);
       }
        
    }
    
}
