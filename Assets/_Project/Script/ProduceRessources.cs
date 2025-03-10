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
    [SerializeField] public Observable<float> drillProgress;
    bool showingRessources = false;

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
            drillProgress.Value = 0;
            StopAllCoroutines();
        }
    }


    public void UpdatePlanetRessourceValues() //Auch beispiel für richtigen planet check
    {


    }
    
void Update()
{
            planetInfoPanelManager = FindAnyObjectByType<PlanetInfoPanelManager>();
        if (planetInfoPanelManager == null) { showingRessources = false; return; }
        if (planetInfoPanelManager.Planetressources == this)
        {
            planetInfoPanelManager.ShowRessources(this);
            showingRessources = true;
            UpdateSlider();
        }
        else
        {
            showingRessources = false;
        }
}

    IEnumerator StartDrill() //Muss noch checken ob es beim richtigen planet ist :<
    {
        drillProgress.Value = 0;

        while (drillProgress.Value < 100)
        {
            yield return new WaitForSeconds(0.8f);

            drillProgress.Value += 25;
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

    public void UpdateSlider()
    {
        if (showingRessources == false) { return; }
        if (slider == null) { slider = FindAnyObjectByType<Slider>(); }

        slider.value = drillProgress.Value;
    }

}
