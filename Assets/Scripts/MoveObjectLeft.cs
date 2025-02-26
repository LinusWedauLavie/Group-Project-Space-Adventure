using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveObjectLeft : MonoBehaviour, IPointerClickHandler
{
    public ItemPickup itemPickup;

    GameObject interactable;
    public float speed;
    public bool hasMoved = false;
    public bool ableToPickUp = false;
    public void Start()
    {
        hasMoved = FindAnyObjectByType<SaveRoomStates>().hasMovedSave;
        if (hasMoved)
        {
            transform.Translate(Vector3.left * speed);
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (hasMoved == false)
        {
            transform.Translate(Vector3.left * speed);
            hasMoved = true;
            ableToPickUp = true;
            itemPickup.ableToPickUp = true;
        }

    }
}
