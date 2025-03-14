using UnityEngine;

public class LabGitter : MonoBehaviour
{
    Item currentItem;
    public Item neededItem;
    InventoryManager inventoryManager;
    public GameObject Gitter;
    public GameObject GitterButton;

    void Start()
    {
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        if (FindAnyObjectByType<SaveRoomStates>().brokeVent)
        {
            Gitter.SetActive(false);
            GitterButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentItem = inventoryManager.GetSelectedItem(false);
    }

    public void OnButtonPress()
    {   
        
        if (neededItem == currentItem )      
        {
            InventoryManager.instance.GetSelectedItem(false);      
            Gitter.SetActive(false);
            GitterButton.SetActive(false);
            FindFirstObjectByType<SaveRoomStates>().brokeVent=true;
        }
        else { DialogueBox dialogueBox = FindAnyObjectByType<DialogueBox>();
            dialogueBox.ShowText("Hmm, da komme ich nicht dran...");
        }
    }
}
