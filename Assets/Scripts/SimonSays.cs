using System;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class SimonSays : MonoBehaviour
{
    SaveRoomStates saveRoomStates;
    public SimonSaysButtons[] buttons;
    public int[] solution = { 1, 4, 1, 4, 2, 3 };
    public int[] currentInput = { 0, 0, 0, 0, 0, 0 };
    bool noMistake = true;
    public Animator animator;
    public int currentRound = 1;
    public int i = 0;
    public int tries = 0;
    public bool done = false;
    public GameObject memoryCard;
    public Button simonSaysEnterButton;

    void Start()
    {
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        animator = GetComponent<Animator>();
        //dmemoryCard.gameObject.SetActive(false) ;    
    }

    void Update()
    {
        if(done)
        {   
            memoryCard.SetActive(true) ;    
        }
    }

    public void StoreButtonIndex(int value)
    {


        animator.SetInteger("Passed", 7);

        currentInput[i] = value;
        if (currentInput[i] == solution[i])
        {
            if (currentRound == i + 1)
            {
                animator.SetInteger("Passed", currentRound);
                currentRound += 1;
                i = 0;
                for (int j = 0; j < solution.Length; j++)
                {
                    currentInput[j] = 0;
                }
                if (currentRound == 7)
                {
                    done = true;
                    saveRoomStates.GetCabinesRoomState();
                    simonSaysEnterButton.enabled = false;

                    animator.SetInteger("Passed", 8);
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



    }
}
