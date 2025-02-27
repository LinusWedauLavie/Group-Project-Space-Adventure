using UnityEngine;

public class SimonSaysButtons : MonoBehaviour
{
    public string direction;
    private SimonSays simonSays;
    void Start()
    {
        
    }    
    void Update()
    {
        
    }
    public void OnButtonPress()
    {
        simonSays.StoreButtonIndex(direction);
    }
    
}
