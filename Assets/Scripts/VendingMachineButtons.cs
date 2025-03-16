using UnityEngine;

public class VendingMachineButtons : MonoBehaviour
{
    public string number;
    public VendingMachine vendingMachine;
    public InventoryManager inventoryManager;
    public Item currentItem; 
    public Item neededItem; 

    void Start()
    {
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inventoryManager == null)
        {
            inventoryManager = FindAnyObjectByType<InventoryManager>();
        }

        currentItem = inventoryManager.GetSelectedItem(false);
    }
    public void OnButtonPress()
    {   
        vendingMachine.StoreInput(number);
    }
    public void InsertCoin()
    {   
        if(currentItem == neededItem)
        { 
            inventoryManager.GetSelectedItem(true);
            vendingMachine.CoinUsed(1);
        }
        
    }
}
