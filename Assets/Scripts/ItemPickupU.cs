using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPickupU : MonoBehaviour, IPointerClickHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject item; 
    void Start()
    {
    }
    public void OnPointerClick(PointerEventData eventData)
    {           
        Destroy(gameObject);
        
    }
    
}
