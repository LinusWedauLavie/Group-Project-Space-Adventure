using TMPro;
using UnityEngine;

public class RohstoffLager : MonoBehaviour
{
    [SerializeField] public Observable<float> Uran, Chemikalien, WeltraumSchrott, MetallErz, Legierungen, Mundspülung, Zitronensäure, TerraSchlangenGift; // Als items Mundspülung, Zitronensäure, TerraSchlangenGift
    static RohstoffLager instance;

    [SerializeField] public Observable<int> currentMiningDrones, totalMiningDrones;

    public TextMeshProUGUI DronesInStorageText, RessourceAmountText;


    [SerializeField] public int speedOfDrills=20; //upgrades 25, 35, 50
    [SerializeField] public int discoveryChance=80; //Wenn Random 1 - 100, kleiner Gleich besser. upgrades 70, 45, 20


    void Awake()
    {
        if (instance != null)
        {
            //Debug.Log("RohstoffLager already exists");
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
        currentMiningDrones.Value = 3; totalMiningDrones.Value = currentMiningDrones.Value;
    }

    public void UpdateDronesInStorage()
    {
        if (DronesInStorageText == null) 
        { 

            if (GameObject.Find("DroneAmountTooltip") == null) {  return; }
            else
            {
                DronesInStorageText= GameObject.Find("DroneAmountTooltip").GetComponent<TextMeshProUGUI>(); 
            }
        }
        DronesInStorageText.text=  "Planet klicken um Abbau zu starten / stoppen\nAbbaudronen übrig: " + currentMiningDrones.Value;
    }

    public void UpdateRessourcesInStorage()
    {
        if (RessourceAmountText == null) 
        {
            if (GameObject.Find("RessourceAmountText") != null)
            {
                RessourceAmountText = GameObject.Find("RessourceAmountText").GetComponent<TextMeshProUGUI>();
            }
            else
            {
                return;
            }
        }
          RessourceAmountText.text = "Uran: \n" + Uran.Value + "\nChemikalien: \n" + Chemikalien.Value + "\nWeltraum\nSchrott: \n" + WeltraumSchrott.Value + "\nMetallErz: \n" + MetallErz.Value + "\nLegierungen: \n" + Legierungen.Value; 
    }

}
