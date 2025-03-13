using Unity.VisualScripting;
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

        if (saveRoomStates.LabRecipeRightSolutionTop == true && this.gameObject.name == "labPaperTop")
        {
            rightSolutionTop = true;
        }
        if (saveRoomStates.LabRecipeRightSolutionMid == true && this.gameObject.name == "labPaperMid")
        {
            rightSolutionMid = true;
        }
        if (saveRoomStates.LabRecipeRightSolutionBottom == true && this.gameObject.name == "labPaperBottom")
        {
            rightSolutionBottom = true;
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
        if (rightSolutionMid == true)
        {
            buttonImage.sprite = recipeFull;
        }
        if (rightSolutionBottom == true)
        {
            buttonImage.sprite = recipeFull;
        }
    }
    public void OnButtonPressRecipe()
    {
        if (neededItem[0] == currentItem)
        {
            InventoryManager.instance.GetSelectedItem(true);      //Wenn zettel 1 plaziert, speicher als zettel 1
            if (neededItem[0].name == "Recipe2")
            {
                rightSolutionTop = true;
                saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
                saveRoomStates.LabRecipeRightSolutionTop = rightSolutionTop;
            }
            if (neededItem[0].name == "Recipe3")
            {
                rightSolutionMid = true;
                saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
                saveRoomStates.LabRecipeRightSolutionMid = rightSolutionMid;
            }
            if (neededItem[0].name == "Recipe1")
            {
                rightSolutionBottom = true;
                saveRoomStates = FindFirstObjectByType<SaveRoomStates>();
                saveRoomStates.LabRecipeRightSolutionBottom = rightSolutionBottom;
            }
            saveRoomStates.GetRoomState();
        }
    }
}
