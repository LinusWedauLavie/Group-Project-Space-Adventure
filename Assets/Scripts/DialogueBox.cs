using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;
using NUnit.Framework.Constraints;
using UnityEngine.InputSystem.Controls;
using System.ComponentModel;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] TMP_Text subtitles;
    //public float targetTime;


    /*
    void Update()
    {
        if (targetTime > 0.0f)
        {
            targetTime -= Time.deltaTime;
        }
        else if (targetTime <= 0.0f)
        {
            if (subtitles==null)
            {
                    subtitles = GameObject.Find("TextBubble").GetComponent<TextMeshProUGUI>();
                Debug.Log("Subtitles were null but hopefully fixed");
            }
            subtitles.text = "";
            targetTime = 0;
        }
    }*/

    public void ShowText(string dialogue)
    {   
        StopAllCoroutines();
        StartCoroutine(ShowTextCoroutine(dialogue));
    }
    //BITTE DIALOGEBOX VON AUFSAMMELBARE OBJEKTE NICHT INS DIE OBJEKTE SELBST EINFÜGEN SONDERN IN EINEM DEMOSPAWN
    IEnumerator ShowTextCoroutine(string dialogue)
    {
        subtitles.text = dialogue;
        yield return new WaitForSeconds(5f);
        subtitles.text = "";
    }
}
