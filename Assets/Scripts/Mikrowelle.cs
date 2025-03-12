using UnityEngine;

public class Mikrowelle : MonoBehaviour
{
    public Item currentItem;
    InventoryManager inventoryManager;
    void Start()
    {
        inventoryManager = FindAnyObjectByType<InventoryManager>();

    }

    void Update()
    {
        
    }
}
