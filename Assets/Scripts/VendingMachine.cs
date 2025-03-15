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

public class VendingMachine : MonoBehaviour
{
    [SerializeField] TMP_Text displayText;
    [SerializeField] TMP_Text coinText;
    string numbers;
    int number; 
    bool correct = false; 
    bool enoughCoins = false;
    public int totalCoins = 0;
    public Button  card; 
    public DialogueBox dialogueBox;
    bool lineSaid = false; 
    void Start()
    {
        displayText.text += "";
        dialogueBox = FindFirstObjectByType<DialogueBox>();
        totalCoins= FindAnyObjectByType<SaveRoomStates>().coinsInVendingMachine;
    }

    // Update is called once per frame
    void Update()
    {      
        if(number == 8)
        {   
            correct = true;
            displayText.text = "Insert Coins";            
        } 
        else if (displayText.text.Length > 2 && correct == false || displayText.text == "0"&& correct == false|| number > 18&& correct == false )
        {   
            displayText.text = "のｔ アヴァイァｂぇ";
            if(lineSaid == false)
            {   
                dialogueBox.ShowText("Ich kann doch kein Scheiß Französisch");
            }
           
        }
        else if(correct == false)
        {
            displayText.text += numbers;
        }
        coinText.text = totalCoins.ToString();
        if( totalCoins == 5 && displayText.text == "Insert Coins")
        {

            if (card != null)
            {
                card.GetComponent<Button>().interactable = true;
                card.GetComponent<ItemPickup>().ableToPickUp = true;
            }
        }

    }
    public void StoreInput(string numbers)
    {  
        int.TryParse(displayText.text, out number);
        
        if(displayText.text == "のｔ アヴァイァｂぇ")
        {      
            displayText.text = "";
        }                
        if(number == 8)
        {   
            correct = true; 
        }
        else if(correct == false)
        {
            displayText.text += numbers;
        }               
    }
    public void CoinUsed(int coins)
    {          
        totalCoins += coins;     
        FindAnyObjectByType<SaveRoomStates>().coinsInVendingMachine = totalCoins;
    }
}
