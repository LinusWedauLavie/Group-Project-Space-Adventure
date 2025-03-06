using UnityEngine;

public class RohstoffLager : MonoBehaviour
{
[SerializeField] public Observable<float> Uran, Chemikalien, WeltraumSchrott, Legierungen, Mundspülung, Zitronensäure, TerraSchlangenGift; // Als items Mundspülung, Zitronensäure, TerraSchlangenGift


    void Start()
    {
        StartValues();
    }

    public void StartValues()
    {
        Uran.Value = 5 ; Chemikalien.Value = 10; WeltraumSchrott.Value = 15;
        Legierungen.Value = 0; Mundspülung.Value = 0; Zitronensäure.Value = 0; TerraSchlangenGift.Value = 0;
    }
}
