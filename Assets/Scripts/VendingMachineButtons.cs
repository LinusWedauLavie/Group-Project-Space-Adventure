using Unity.VisualScripting;
using UnityEngine;

public class VendingMachineButtons : MonoBehaviour
{
    public string number;
    public VendingMachine vendingMachine;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPress()
    {   
        vendingMachine.StoreInput(number);
    }
}
