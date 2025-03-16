using System.Collections;
using UnityEngine;
using TMPro;

public class MedbayScan : MonoBehaviour
{
    SaveRoomStates saveRoomStates;
    [SerializeField] TMP_Text text;
    public int timer;
    public bool scanDone = false;
    public GameObject player;
    public int communism = 0;
    bool scanStart = false;
    Vector2 Scanposition = new Vector2(-5.5f, -2.4f);
    public GameObject memoryCard;
    void Start()
    {
        saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
        player = FindAnyObjectByType<ClickCharacterMove>().gameObject;
        scanDone = saveRoomStates.scanDone;
    }

    public void StartScan()
    {
        if (scanStart == false && scanDone == false && communism == 2)
        {
            saveRoomStates.medbayScan = true;
            scanStart = true;
            player.transform.position = Scanposition;
            FindAnyObjectByType<ClickCharacterMove>().relativePosition = new Vector2(0, 0);
            FindAnyObjectByType<ClickCharacterMove>().speed = new Vector2(0, 0);
            StartCoroutine(WaitASec());
        }
        else if (scanStart == false && scanDone == false)
        {
            FindAnyObjectByType<DialogueBox>().ShowText("Was ist das? EIn Scanner?");
        }
    }
    private void Update()
    {

        if (scanStart)
        {
            player.transform.position = Scanposition;
        }
    }
    public IEnumerator WaitASec()
    {

        for (timer = 10; timer >= 0; timer--)
        {
            if (timer == 1)
            {
                text.text = "Capitalist";
            }
            else if (timer == 9)
            {
                text.text = "Transgenderism";
            }
            else if (timer == 8)
            {
                text.text = "Depression";
            }
            else if (timer == 7)
            {
                text.text = "Gay";
            }
            else if (timer == 6)
            {
                text.text = "Anxiety";
            }
            else if (timer == 5)
            {
                text.text = "French";
            }
            else if (timer == 4)
            {
                text.text = "HIV/AIDS";
            }
            else if (timer == 3)
            {
                text.text = "Your Mum";
            }
            else if (timer == 2)
            {
                text.text = "Opperman";
            }
            else if (timer == 0)
            {
                text.text = "All Clear!";
                scanDone = true;
                scanStart = false;
                saveRoomStates.medbayScan = false;
                memoryCard.SetActive(true);
                player.transform.position = new Vector2(-5.6f, -3.8f);
                FindAnyObjectByType<ClickCharacterMove>().speed = new Vector2(5, 2);

            }
            else if (timer == 10)
            {
                text.text = "Loading...";
            }
            yield return new WaitForSeconds(0.2f);
        }

    }
}
