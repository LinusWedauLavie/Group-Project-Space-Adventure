using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SimonSays : MonoBehaviour
{
    public SimonSaysButtons[] buttons;
    public int[] solution = {1,4,1,4,2,3};
    public int[] currentInput = { 0, 0, 0, 0, 0, 0 };
    bool noMistake = true;
    public Animator animator;
    public int currentRound = 1;
    public int i = 0;
    public int tries =0;
    bool done = false; 

    void Start()
    {
       animator = GetComponent<Animator>();
    }
    
    public void StoreButtonIndex(int value)
    {

        if (done) return;

        animator.SetInteger("Passed", 7);

        currentInput[i] = value;
        if (currentInput[i] == solution[i])
        {
            if (currentRound == i+1)
            {
                animator.SetInteger("Passed", currentRound);
                currentRound +=1;
                i = 0;
                for (int j = 0; j < solution.Length; j++)
                {
                    currentInput[j] = 0;
                }
                if (currentRound == 7)
                {
                    done = true;
                    Debug.Log("Done!");
                }
            }
            else
            {
                i += 1;
            }
        }
        else
        {
            Reset();
        }

        void Reset()
        {
            currentRound = 1;
            i = 0;
            for (int j = 0; j < solution.Length; j++)
            {
                currentInput[j] = 0;
            }
            animator.SetInteger("Passed", 0);
        }

        /*
        Debug.Log(value);
        currentInput[i] = value;
        if (currentInput[i] == solution[i])
        {
            i += 1;
            animator.SetInteger("Passed", i);
            tries = 0;
            Debug.Log("i: " + i);


            if (i >= solution.Length)
            {
                done = true;
            }

        }
        else
        {
            tries++;
        }



        if (tries>=i+1)
        {
            i = 0;

            animator.SetInteger("Passed", i);
            for (int j = 0; j < solution.Length; j++)
            {
                currentInput[j] = 0;
            }
        }
        */
            /*
                for( ; i < 6; i++)
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
            */
    }
}
