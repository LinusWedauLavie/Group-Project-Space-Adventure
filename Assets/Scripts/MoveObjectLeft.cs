using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveObjectLeft : MonoBehaviour, IPointerClickHandler
{
    public ItemPickup itemPickup;
    SaveRoomStates saveRoomStates;

    GameObject interactable;
    public float speed;
    public bool hasMoved = false;
    public bool ableToPickUp = false;
    public void Start()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        if (saveRoomStates.cryoCompletedSave)
        {
            hasMoved = true;
            Button button = GetComponent<Button>();
            button.enabled = false;
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
