using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    
    public UnityEngine.UI.Image image; 
    [HideInInspector] public Item item;

    private MoveObjectLeft ableToPickUps;
    public GameObject ableToPickUp;

    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    int selectedSlot = 3;
    //int number = 0;
    //public ItemPickup itemPickup;
    public InventorySlot inventorySlot;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            //DontDestroyOnLoad(gameObject); Es ist child von einem DontDestroyOnLoad Object
        }
    }
    void Update()
    {
       
    }


    public void ChangedSelectedSlot (int newValue)
    {
        if (selectedSlot >= 0)
        {
            inventorySlots[selectedSlot].Deselect();
        }

        inventorySlots[newValue].Select();
        selectedSlot = newValue;
    }
    void Start()
    {
        
    }
    
    public void UpdateRessourcesInStorage()
    {
        RohstoffLager rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        if (rohstoffLager == null) { return; }
        else
        {
            rohstoffLager.UpdateRessourcesInStorage();
        }
    }

    public void AddItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if(itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return;
            }
        }
    }
    void SpawnNewItem(Item item, InventorySlot slot)
    {        
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }
    
    public Item GetSelectedItem(bool use)
    {
        InventorySlot slot = inventorySlots[selectedSlot];
        InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
        if(itemInSlot != null)        
        {
            Item item = itemInSlot.item;

            if ( use == true){
                itemInSlot.count--;
                if(itemInSlot.count <= 0)
                {
                    Destroy(itemInSlot. gameObject);
                }
            }

            return item;
        }
        return null;
    }

}
