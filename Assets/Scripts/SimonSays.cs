using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SimonSays : MonoBehaviour
{
    public SimonSaysButtons[] buttons;
    public int[] solution = {1,4,1,4,2,3};
    public int[] currentInput = new int[5];
    bool noMistake = true;
    public Animator animator;
    int i = 0;
    bool done = false; 
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
    public void StoreButtonIndex(int value)
    {   
        
        Debug.Log(value);               
        
            for(i = 0; i < 6; i++)
            {
                currentInput[i] = value;
                if (currentInput[i] == solution[i])
                {           
                    Debug.Log("B"+ (i));
                    Debug.Log("C"+ value);
                    i += 1;
                    animator.SetInteger("Passed", i);
                }  
                else
                {
                    noMistake = false;
                }
            }
            if(currentInput[5] == solution[5])
            {   
                done = true; 
            }
        
    }
}
