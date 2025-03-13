using UnityEngine;

public class VoicelineWhenEnterBridge : MonoBehaviour
{
    DialogueBox dialogueBox;
    bool dialogueShown = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueBox = FindFirstObjectByType<DialogueBox>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueShown == false)
        {
            dialogueBox.ShowText("Hey, da liegt ja eine Floppy Disk und da neben ist ein Floppy Disk Reader");
            dialogueShown = true;
        }
        
    }
}
