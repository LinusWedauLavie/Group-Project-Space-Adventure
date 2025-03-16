using System.Collections;
using UnityEngine;

public class Mikrowelle : MonoBehaviour
{
    public Animator animator;
    public RohstoffLager rohstoffLager;
    public DialogueBox dialogueBox;

    bool isCurrentlyCooking;
    void Start()
    {
        rohstoffLager = FindFirstObjectByType<RohstoffLager>();
        dialogueBox = FindFirstObjectByType<DialogueBox>();
    }
    public void MikroWelleClicked()
    {
        if (isCurrentlyCooking)
        {
            return;
        }
        if (rohstoffLager == null)
        {
            dialogueBox.ShowText("Eine...Mikrowelle? Mit 1 MetallErz und 1 Weltraumschrott kÖnnte ich Legierungen schmelzen!");
            return;
        }
        else if (rohstoffLager.MetallErz.Value >= 1 && rohstoffLager.WeltraumSchrott.Value >= 1)
        {
            StartCoroutine(PlayAnim());
        }
        else
        {
            dialogueBox.ShowText("Eine...Mikrowelle? Mit 1 MetallErz und 1 Weltraumschrott kÖnnte ich Legierungen schmelzen!");
        }
    }

    IEnumerator PlayAnim()
    {
        isCurrentlyCooking = true;
        animator.SetBool("IsRunning", true);
        yield return new WaitForSeconds(2.4f);


        while (rohstoffLager.MetallErz.Value >= 1 && rohstoffLager.WeltraumSchrott.Value >= 1)
        {
            rohstoffLager.MetallErz.Value--;
            rohstoffLager.WeltraumSchrott.Value--;
            rohstoffLager.Legierungen.Value++;
        }
        isCurrentlyCooking = false;
        animator.SetBool("IsRunning", false);
    }
}
