using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveObjectLeft : MonoBehaviour, IPointerClickHandler
{
    GameObject interactable;
    public float speed;
    bool hasMoved;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {      
        if( hasMoved == false ) 
        {
             transform.Translate(Vector3.left * speed );
             hasMoved = true;
        }
       
    }
}
