using UnityEngine;

public class MedbayCommie : MonoBehaviour
{
    public Sprite full;
    public Sprite empty;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item neededItem;
    UnityEngine.UI.Image buttonImage;
    public MedbayScan medbayScan;

    void Start()
    {
        buttonImage = GetComponent<UnityEngine.UI.Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        buttonImage.sprite = empty;
    }
    void Update()
    {
        currentItem = inventoryManager.GetSelectedItem(false);
    }
    public void OnButtonPressRecipe()
    {           
        if (neededItem == currentItem )      
        {
            InventoryManager.instance.GetSelectedItem(true);      
            medbayScan.communism += 1;
            buttonImage.sprite = full;
        }
    }
}
