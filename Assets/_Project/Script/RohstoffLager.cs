using UnityEngine;

public class RohstoffLager : MonoBehaviour
{
    [SerializeField] public Observable<float> Uran, Chemikalien, WeltraumSchrott, MetallErz, Legierungen, Mundspülung, Zitronensäure, TerraSchlangenGift; // Als items Mundspülung, Zitronensäure, TerraSchlangenGift
    static RohstoffLager instance;

    public int miningDrones = 1;



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
            Debug.Log("RohstoffLager created");
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
    }


}
