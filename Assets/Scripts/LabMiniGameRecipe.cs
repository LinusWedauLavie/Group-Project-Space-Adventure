using UnityEngine;

public class LabMiniGameRecipe : MonoBehaviour
{
    SaveRoomStates saveRoomStates;
    public Sprite recipeFull;
    public Sprite recipeEmpty;
    int level = 0;
    UnityEngine.UI.Image buttonImage;
    public InventoryManager inventoryManager;
    public Item currentItem;
    public Item[] neededItem;
    public bool rightSolutionTop, rightSolutionMid, rightSolutionBottom = false; 
    void Start()
    {
        buttonImage = GetComponent<UnityEngine.UI.Image>();
        inventoryManager = FindAnyObjectByType<InventoryManager>();
        buttonImage.sprite = recipeEmpty;
        saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
        if(rightSolutionBottom || rightSolutionMid || rightSolutionTop)
        {
            Debug.Log("Bitte");
            rightSolutionTop = saveRoomStates.LabRecipeRightSolutionTop;
            rightSolutionMid = saveRoomStates.LabRecipeRightSolutionMid;
            rightSolutionBottom = saveRoomStates.LabRecipeRightSolutionBottom;
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentItem = inventoryManager.GetSelectedItem(false);
        if (rightSolutionTop == true)
        {   
            buttonImage.sprite = recipeFull;
        }
        if(rightSolutionMid == true)      
        {   
            buttonImage.sprite = recipeFull;
        }
        if(rightSolutionBottom == true)      
        {   
            buttonImage.sprite = recipeFull;
        }
    }
    public void OnButtonPressRecipe()
    {   
        if (neededItem[0] == currentItem )      
        {
            InventoryManager.instance.GetSelectedItem(false);      //Wenn zettel 1 plaziert, speicher als zettel 1
            if (neededItem[0].name == "Recipe2")
            {
                rightSolutionTop = true;
            }
            if (neededItem[0].name == "Recipe3")
            {
                rightSolutionMid = true;
            }
            if (neededItem[0].name == "Recipe1")
            {
                rightSolutionBottom = true;
            }
            saveRoomStates.GetRoomState();
        }
        Debug.Log("SAve");
    }
}
