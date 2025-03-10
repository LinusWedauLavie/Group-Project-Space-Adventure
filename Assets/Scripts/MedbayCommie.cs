using UnityEngine;

public class MedbayCommie : MonoBehaviour
{
    public Sprite full;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item neededItem;
    UnityEngine.UI.Image buttonImage;
    public MedbayScan medbayScan;

    void Start()
    {
        buttonImage = GetComponent<UnityEngine.UI.Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }
    public void OnButtonPressRecipe()
    {           
        currentItem = inventoryManager.GetSelectedItem(false);
        if (neededItem == currentItem )      
        {
            InventoryManager.instance.GetSelectedItem(true);      
            medbayScan.communism += 1;
        }
    }
}
