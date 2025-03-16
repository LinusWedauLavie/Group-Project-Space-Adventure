using System.Linq;
using UnityEngine;

public class CableMiniGame : MonoBehaviour
{
    public ButtonMiniGame[] buttons; // Array to hold the child objects
    public int[] buttonPositions; // This array will store the button indexes
    public bool rightSolution, wrongSolution; 
    DialogueBox dialogueBox;

    void Start()
    {
        dialogueBox = FindAnyObjectByType<DialogueBox>();
        // Initialize the array to match the button count
        buttonPositions = new int[buttons.Length];

        // Assign the index to each button and notify them
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetIndex(i, this);
        }
    }
    void Update()
    {
        int[] arr = {0,0,0,0,0,0,0,0,0};
        if (wrongSolution == true)
        {
            buttonPositions = arr;
            wrongSolution = false;
        }
    }

    // Method to receive the button's index and store it
    public void StoreButtonIndex(int index)
    {
        buttonPositions[index] = index;
        
        int cableSum = buttonPositions.Sum();
        if (index == 2 || index == 3|| index == 6|| index == 7)
        {
            //Debug.Log("Boom");
           wrongSolution = true;
        }
        if (cableSum == 18 && buttonPositions[0] == 0 && buttonPositions[1] == 1 && buttonPositions[4] == 4 && buttonPositions[5] == 5 && buttonPositions[8] == 8)
        {
            wrongSolution = false;
            rightSolution = true; 
            InventoryManager.instance.GetSelectedItem(true);
            dialogueBox.ShowText("Verdammt! Meine KettensÄge ist kaputt gegangen :(");
        }
        
    }

    
}
