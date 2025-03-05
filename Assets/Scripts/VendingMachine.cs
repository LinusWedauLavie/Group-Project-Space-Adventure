using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VendingMachine : MonoBehaviour
{
    [SerializeField] TMP_Text displayText;
    string numbers;
    void Start()
    {
        displayText.text += "";
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text += numbers;
    }
    public void StoreInput( string numbers)
    {   
        displayText.text += numbers;
    }
}
