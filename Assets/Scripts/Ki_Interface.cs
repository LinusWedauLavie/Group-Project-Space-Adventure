using UnityEngine;
using UnityEngine.UI;

public class Ki_Interface : MonoBehaviour
{
    public GameObject kiCanvas;
    public Button button;
    public GameObject storytext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KiInterfaceButtonClick(bool activate)
    {
        kiCanvas.SetActive(activate);

        //storytext.SetActive(true);

        //TODO machen das sich das Interface öffnet



    }


    

    public void MemoryCardButtonClick(string buttonName)
    {
        switch(buttonName)
        {
            case "Memory Card 1":
                //Debug.Log("test33r24");
                storytext.SetActive(true);
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 2":
                //Debug.Log("test2398048907235");
                storytext.SetActive(true);
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 3":
                storytext.SetActive(true);
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 4":
                storytext.SetActive(true);
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 5":
                storytext.SetActive(true);
                //TODO machen das man den Text sieht
            break;
            case "Memory Card 6":
                storytext.SetActive(true);
                //TODO machen das man den Text sieht
            break;
            
        }
    }
}
