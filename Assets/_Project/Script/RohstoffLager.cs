using TMPro;
using UnityEngine;

public class RohstoffLager : MonoBehaviour
{
    [SerializeField] public Observable<float> Uran, Chemikalien, WeltraumSchrott, MetallErz, Legierungen, Mundspülung, Zitronensäure, TerraSchlangenGift; // Als items Mundspülung, Zitronensäure, TerraSchlangenGift
    static RohstoffLager instance;

    [SerializeField] public Observable<int> MiningDrones;

    TextMeshProUGUI DronesInStorageText;

    [SerializeField] public int speedOfDrills=20; //upgrades 25, 35, 50
    [SerializeField] public int discoveryChance=100; //Wenn Random 1 - 100, kleiner Gleich besser. upgrades 70, 45, 20


    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            //Debug.Log("RohstoffLager created");
        }
    }

    void Start()
    {
        StartValues();
    }

    public void StartValues()
    {
        Uran.Value = 5; Chemikalien.Value = 10; WeltraumSchrott.Value = 15;
        MetallErz.Value = 0; Legierungen.Value = 0; Mundspülung.Value = 0; Zitronensäure.Value = 0; TerraSchlangenGift.Value = 0;
        MiningDrones.Value = 2;
    }

    public void UpdateDronesInStorage()
    {
        if (DronesInStorageText == null) { DronesInStorageText= GameObject.Find("DroneAmountTooltip").GetComponent<TextMeshProUGUI>(); }
        DronesInStorageText.text=  "Planet klicken um Abbau zu starten / stoppen\nAbbaudronen übrig: " + MiningDrones.Value;
    }

}
