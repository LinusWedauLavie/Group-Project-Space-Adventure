using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SimonSays : MonoBehaviour
{
    public SimonSaysButtons[] buttons;
    public string[] solution = {"up", "down", "up", "down", "left", "right"};
    public string[] currentInput= {"a", "a", "a", "a", "a", "a"};
    bool noMistake = true;
    public Animator animator;
    int i = 0;
    void Start()
    {
       animator = GetComponent<Animator>();
    }
    
    void Update()
    {

        /*while(noMistake == true)
        {   
            for( int i = 6; i > 0; i--)
            {
                if(noMistake)
                {
                    int counter = 0; 
                    if (currentInput[counter] == solution[counter])
                    {
                        counter++;
                        animator.SetInteger("Passed", i);
                    }                   
                }
                else
                {   
                  noMistake = false; 
                }
            }
        }*/
        noMistake = true;
    }
    public void StoreButtonIndex(string direction)
    {   
        
        Debug.Log(direction);
        while(noMistake == true)
        {           
            currentInput[1] = direction;
          
            for(int counter = 0; counter >= 6; counter++)
            {
                if (currentInput[i] == solution[i])
                {
                    counter++;
                    animator.SetInteger("Passed", counter);
                }  
                else
                {
                    noMistake = false;
                }
            }
        }
    }
}
