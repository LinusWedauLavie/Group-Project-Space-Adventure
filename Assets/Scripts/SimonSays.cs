using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class SimonSays : MonoBehaviour
{
    public SimonSaysButtons[] buttons;
    public string[] solution = {"up", "down", "up", "down", "left", "right"};
    public string[] currentInput;
    bool noMistake = true;     
    void Start()
    {
        while(noMistake == true)
        {
            if (currentInput[0] == solution[0])
            {
                
            }
        }
    }
    
    void Update()
    {
        
    }
    public void StoreButtonIndex(string direction)
    {   
        int i = 0;
        if(noMistake == false)
            {
                i = 0;
            } 
       direction = currentInput[i];
       i++;
      
    }
}
