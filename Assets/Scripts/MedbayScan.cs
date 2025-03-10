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

public class MedbayScan : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public int timer;
    
    void Start()
    {
        StartCoroutine(WaitASec());
    }
    


    public IEnumerator WaitASec()
    {
        
        for ( timer = 10; timer > 0; timer-- )
        {
            if (timer <= 0)
        {
            timer = 0;
        }        
        if(timer == 5)
        {   
            text.text ="Slay";
        }
        if(timer == 8f)
        {   
            text.text ="Way";
        }
        yield return new WaitForSeconds(0.8f);
        }
        
    }
}
