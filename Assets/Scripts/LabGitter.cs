using UnityEngine;

public class LabGitter : MonoBehaviour
{
    Item currentItem;
    public Item neededItem;
    InventoryManager inventoryManager;
    public GameObject Gitter;
    void Start()
    {
        inventoryManager = FindAnyObjectByType<InventoryManager>();
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
        }
    }
}
