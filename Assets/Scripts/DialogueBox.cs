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
    public float targetTime = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            subtitles.text = "";
            targetTime = 0;
        }
    }

    public void ShowText(string dialogue)
    {   
        targetTime = 5f;
        subtitles.text = dialogue;
        if (targetTime <= 0.0f)
        {
            subtitles.text = "";
            targetTime = 0;
        }
    }
}
