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
        if (timer == 0)
        {
            
        }        
        else if (timer == 9) 
        {   
            text.text = "Tuberculosis";
        }
        else if (timer == 8) 
        {   
            text.text = "Malaria";
        }
        else if (timer == 7) 
        {   
            text.text = "Leprosy";
        }
        else if (timer == 6) 
        {   
            text.text = "Cholera";
        }
        else if (timer == 5) 
        {   
            text.text = "Plague";
        }
        else if (timer == 4) 
        {   
            text.text = "HIV/AIDS";
        }
        else if (timer == 3) 
        {   
            text.text = "Dengue";
        }
        else if (timer == 2) 
        {   
            text.text = "Ebola";
        }
        else if (timer == 1) 
        {   
            text.text = "All Clear!";
        }
        else if(timer == 10)
        {   
            text.text ="Loading...";
        }
        yield return new WaitForSeconds(0.2f);
        }
        
    }
}
