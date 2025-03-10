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
    bool scanDone = false;
    public GameObject player;
    public int communism = 0;
    
    void Start()
    {
        
    }
    
    public void StartScan()
    {
        if (scanDone == false && communism == 2)
        {
            StartCoroutine(WaitASec());
        }        
    }

    public IEnumerator WaitASec()
    {
        
        for ( timer = 10; timer >= 0; timer-- )
        {
        if (timer == 1)
        {
            text.text = "Capitalist";
        }        
        else if (timer == 9) 
        {   
            text.text = "Transgenderism";
        }
        else if (timer == 8) 
        {   
            text.text = "Depression";
        }
        else if (timer == 7) 
        {   
            text.text = "Gay";
        }
        else if (timer == 6) 
        {   
            text.text = "Anxiety";
        }
        else if (timer == 5) 
        {   
            text.text = "French";
        }
        else if (timer == 4) 
        {   
            text.text = "HIV/AIDS";
        }
        else if (timer == 3) 
        {   
            text.text = "Your Mum";
        }
        else if (timer == 2) 
        {   
            text.text = "Opperman";
        }
        else if (timer == 0) 
        {   
            text.text = "All Clear!";
            scanDone = true;
        }
        else if(timer == 10)
        {   
            text.text ="Loading...";
        }
        yield return new WaitForSeconds(0.2f);
        }
        
    }
}
