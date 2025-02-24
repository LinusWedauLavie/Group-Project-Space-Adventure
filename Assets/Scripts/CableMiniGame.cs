using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CableMiniGame : MonoBehaviour
{
    public ButtonMiniGame[] buttons; // Array to hold the child objects
    public int[] buttonPositions; // This array will store the button indexes
    public bool rightSolution, wrongSolution; 

    void Start()
    {
        // Initialize the array to match the button count
        buttonPositions = new int[buttons.Length];

        // Assign the index to each button and notify them
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetIndex(i, this);
        }
    }
   
    // Method to receive the button's index and store it
    public void StoreButtonIndex(int index)
    {
        buttonPositions[index] = index;
        int cableSum = buttonPositions.Sum();
        if (index == 2 || index == 3|| index == 6|| index == 7)
        {
            Debug.Log("Boom");
            wrongSolution = true;
        }
        else if (cableSum == 18)
        {
            Debug.Log("Yay");
            rightSolution = true; 
        }
    }

    
}
