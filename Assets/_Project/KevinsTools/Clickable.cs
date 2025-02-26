using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using KBCore.Refs;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : ValidatedMonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    //[SerializeField,Anywhere] ReadInputOfOther otherScript;

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Up");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Click");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Exit");
    }
}
