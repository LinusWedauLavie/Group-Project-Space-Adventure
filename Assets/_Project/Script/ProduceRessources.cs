using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProduceRessources : MonoBehaviour
{
    [SerializeField] public Observable<float> PlanetUran, PlanetChemikalien, PlanetWeltraumSchrott, PlanetMetallErz, PlanetLegierungen, PlanetMundspülung, PlanetZitronensäure, PlanetTerraSchlangenGift; //Spawnchancen für die Rohstoffe

    RohstoffLager rohstoffLager;
    PlanetInfoPanelManager planetInfoPanelManager;
    bool isDrilling;
    Slider slider;

    private void Start()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
    }

    public void PlanetDrillStartClicked()
    {
        if (rohstoffLager.MiningDrones.Value > 0 && isDrilling == false)
        {
            rohstoffLager.MiningDrones.Value--;
            isDrilling = true;
            StartCoroutine(StartDrill());
        }
        else if (isDrilling == true)
        {
            rohstoffLager.MiningDrones.Value++;
            isDrilling = false;
            FindAnyObjectByType<Slider>().value = 0;
            StopAllCoroutines();
        }
    }


    public void UpdatePlanetRessourceValues() //Auch beispiel für richtigen planet check
    {
        if (FindAnyObjectByType<PlanetInfoPanelManager>() == null) { return; }
        if(FindAnyObjectByType<PlanetInfoPanelManager>().Planetressources == this)
        {
            FindAnyObjectByType<PlanetInfoPanelManager>().ShowRessources(this);
        }
        
    }

    IEnumerator StartDrill() //Muss noch checken ob es beim richtigen planet ist :<
    {
           slider= FindAnyObjectByType<Slider>();
        slider.value = 0;

        while (slider.value < 100)
        {
            yield return new WaitForSeconds(0.8f);
            if (slider == null)
            {
                slider=FindAnyObjectByType<Slider>();
            }
            slider.value+=25;
        }

        yield return new WaitForSeconds(0.2f);
        int random1 = Random.Range(1, 100);
        if (random1 <= PlanetUran.Value)
        {
            PlanetUran.Value--;
            rohstoffLager.Uran.Value++;
        }
        if (random1 <= PlanetChemikalien.Value)
        {
            PlanetChemikalien.Value--;
            rohstoffLager.Chemikalien.Value++;
        }
        if (random1 <= PlanetWeltraumSchrott.Value)
        {
            PlanetWeltraumSchrott.Value--;
            rohstoffLager.WeltraumSchrott.Value++;
        }
        if (random1 <= PlanetMetallErz.Value)
        {
            PlanetMetallErz.Value--;
            rohstoffLager.MetallErz.Value++;
        }
        if (random1 <= PlanetLegierungen.Value)
        {  
            PlanetLegierungen.Value--;
            rohstoffLager.Legierungen.Value++;
        }
        if (random1 <= PlanetMundspülung.Value)
        {
            PlanetMundspülung.Value--;
            rohstoffLager.Mundspülung.Value++;
        }
        if (random1 <= PlanetZitronensäure.Value)
        {
            PlanetZitronensäure.Value--;
            rohstoffLager.Zitronensäure.Value++;
        }
        if (random1 <= PlanetTerraSchlangenGift.Value)
        {
            PlanetTerraSchlangenGift.Value--;
            rohstoffLager.TerraSchlangenGift.Value++;
        }


        StartCoroutine(StartDrill());
    }
}
