using UnityEngine;

public class LabMiniGameRecipe : MonoBehaviour
{
    public Sprite recipeFull;
    public Sprite recipeEmpty;
    int level = 0;
    UnityEngine.UI.Image buttonImage;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item[] neededItem;
    public bool rightSolution; 
    void Start()
    {
        buttonImage = GetComponent<UnityEngine.UI.Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        currentItem = InventoryManager.instance.GetSelectedItem(false);
        if (rightSolution == true)
        {   
            buttonImage.sprite = recipeFull;
        }
        else 
        {   
            buttonImage.sprite = recipeEmpty;
        }
        
    }
    public void OnButtonPressRecipe()
    {   
        
        if (neededItem[0] == currentItem )      
        {
            InventoryManager.instance.GetSelectedItem(false);      
            rightSolution= true;
        }
    }
}
