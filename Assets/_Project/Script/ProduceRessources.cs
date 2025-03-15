using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProduceRessources : MonoBehaviour
{
    [SerializeField] public Observable<float> PlanetUran, PlanetChemikalien, PlanetWeltraumSchrott, PlanetMetallErz, PlanetLegierungen, PlanetMundspülung, PlanetZitronensäure, PlanetTerraSchlangenGift; //Spawnchancen für die Rohstoffe

    public RohstoffLager rohstoffLager; //Nichts ändern
    PlanetInfoPanelManager planetInfoPanelManager;
    bool isDrilling;
    Slider slider;
    [SerializeField] public Observable<float> drillProgress;
    bool showingRessources = false;

    private void Start()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        SaveRoomStates saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
        if (saveRoomStates.IcyPlanetChemikalien == 0 && saveRoomStates.IcyPlanetWeltraumSchrott == 0 && saveRoomStates.IcyPlanetUran==0) { return; }
        Debug.Log("Saves Werden geladen");
        switch (this.gameObject.name)
        {

            case "Goats Grand Maw":
                PlanetUran.Value = saveRoomStates.GoatsGrandMawPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.GoatsGrandMawPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.GoatsGrandMawPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.GoatsGrandMawPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.GoatsGrandMawPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.GoatsGrandMawPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.GoatsGrandMawPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.GoatsGrandMawPlanetTerraSchlangenGift;
                break;
            case "Delta Lambtauri":
                PlanetUran.Value = saveRoomStates.DeltaLambtauriPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.DeltaLambtauriPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.DeltaLambtauriPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.DeltaLambtauriPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.DeltaLambtauriPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.DeltaLambtauriPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.DeltaLambtauriPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.DeltaLambtauriPlanetTerraSchlangenGift;
                break;
            case "Icy":
                PlanetUran.Value = saveRoomStates.IcyPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.IcyPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.IcyPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.IcyPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.IcyPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.IcyPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.IcyPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.IcyPlanetTerraSchlangenGift;
                break;
            case "X-03 Molten":
                PlanetUran.Value = saveRoomStates.X03MoltenPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.X03MoltenPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.X03MoltenPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.X03MoltenPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.X03MoltenPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.X03MoltenPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.X03MoltenPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.X03MoltenPlanetTerraSchlangenGift;
                break;
            case "Verfluchter Terran":
                PlanetUran.Value = saveRoomStates.VerfluchterTerranPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.VerfluchterTerranPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.VerfluchterTerranPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.VerfluchterTerranPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.VerfluchterTerranPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.VerfluchterTerranPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.VerfluchterTerranPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.VerfluchterTerranPlanetTerraSchlangenGift;
                break;
            case "Great Sparkle":
                PlanetUran.Value = saveRoomStates.GreatSparklePlanetUran;
                PlanetChemikalien.Value = saveRoomStates.GreatSparklePlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.GreatSparklePlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.GreatSparklePlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.GreatSparklePlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.GreatSparklePlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.GreatSparklePlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.GreatSparklePlanetTerraSchlangenGift;
                break;
            case "Lavaeater":
                PlanetUran.Value = saveRoomStates.LavaeaterPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.LavaeaterPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.LavaeaterPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.LavaeaterPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.LavaeaterPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.LavaeaterPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.LavaeaterPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.LavaeaterPlanetTerraSchlangenGift;
                break;
            case "Storm E":
                PlanetUran.Value = saveRoomStates.StormEPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.StormEPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.StormEPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.StormEPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.StormEPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.StormEPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.StormEPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.StormEPlanetTerraSchlangenGift;
                break;
            case "Effing Failure":
                PlanetUran.Value = saveRoomStates.EffingFailurePlanetUran;
                PlanetChemikalien.Value = saveRoomStates.EffingFailurePlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.EffingFailurePlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.EffingFailurePlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.EffingFailurePlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.EffingFailurePlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.EffingFailurePlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.EffingFailurePlanetTerraSchlangenGift;
                break;
            case "Terrarium":
                PlanetUran.Value = saveRoomStates.TerrariumPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.TerrariumPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.TerrariumPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.TerrariumPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.TerrariumPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.TerrariumPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.TerrariumPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.TerrariumPlanetTerraSchlangenGift;
                break;
            case "Jupitwo":
                PlanetUran.Value = saveRoomStates.JupitwoPlanetUran;
                PlanetChemikalien.Value = saveRoomStates.JupitwoPlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.JupitwoPlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.JupitwoPlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.JupitwoPlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.JupitwoPlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.JupitwoPlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.JupitwoPlanetTerraSchlangenGift;
                break;
            case "Orange":
                PlanetUran.Value = saveRoomStates.OrangePlanetUran;
                PlanetChemikalien.Value = saveRoomStates.OrangePlanetChemikalien;
                PlanetWeltraumSchrott.Value = saveRoomStates.OrangePlanetWeltraumSchrott;
                PlanetMetallErz.Value = saveRoomStates.OrangePlanetMetallErz;
                PlanetLegierungen.Value = saveRoomStates.OrangePlanetLegierungen;
                PlanetMundspülung.Value = saveRoomStates.OrangePlanetMundspülung;
                PlanetZitronensäure.Value = saveRoomStates.OrangePlanetZitronensäure;
                PlanetTerraSchlangenGift.Value = saveRoomStates.OrangePlanetTerraSchlangenGift;
                break;
        }
    }

    public void SaveRessourcesLeftOnPlanet()
    {
        SaveRoomStates saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
        switch (this.gameObject.name)
        {
            case "Goats Grand Maw":
                saveRoomStates.GoatsGrandMawPlanetUran = PlanetUran.Value;
                saveRoomStates.GoatsGrandMawPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.GoatsGrandMawPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.GoatsGrandMawPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.GoatsGrandMawPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.GoatsGrandMawPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.GoatsGrandMawPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.GoatsGrandMawPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Delta Lambtauri":
                saveRoomStates.DeltaLambtauriPlanetUran = PlanetUran.Value;
                saveRoomStates.DeltaLambtauriPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.DeltaLambtauriPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.DeltaLambtauriPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.DeltaLambtauriPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.DeltaLambtauriPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.DeltaLambtauriPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.DeltaLambtauriPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Icy":
                saveRoomStates.IcyPlanetUran = PlanetUran.Value;
                saveRoomStates.IcyPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.IcyPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.IcyPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.IcyPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.IcyPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.IcyPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.IcyPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "X-03 Molten":
                saveRoomStates.X03MoltenPlanetUran = PlanetUran.Value;
                saveRoomStates.X03MoltenPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.X03MoltenPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.X03MoltenPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.X03MoltenPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.X03MoltenPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.X03MoltenPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.X03MoltenPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Verfluchter Terran":
                saveRoomStates.VerfluchterTerranPlanetUran = PlanetUran.Value;
                saveRoomStates.VerfluchterTerranPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.VerfluchterTerranPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.VerfluchterTerranPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.VerfluchterTerranPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.VerfluchterTerranPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.VerfluchterTerranPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.VerfluchterTerranPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Great Sparkle":
                saveRoomStates.GreatSparklePlanetUran = PlanetUran.Value;
                saveRoomStates.GreatSparklePlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.GreatSparklePlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.GreatSparklePlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.GreatSparklePlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.GreatSparklePlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.GreatSparklePlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.GreatSparklePlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Lavaeater":
                saveRoomStates.LavaeaterPlanetUran = PlanetUran.Value;
                saveRoomStates.LavaeaterPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.LavaeaterPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.LavaeaterPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.LavaeaterPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.LavaeaterPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.LavaeaterPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.LavaeaterPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Storm E":
                saveRoomStates.StormEPlanetUran = PlanetUran.Value;
                saveRoomStates.StormEPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.StormEPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.StormEPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.StormEPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.StormEPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.StormEPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.StormEPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Effing Failure":
                saveRoomStates.EffingFailurePlanetUran = PlanetUran.Value;
                saveRoomStates.EffingFailurePlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.EffingFailurePlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.EffingFailurePlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.EffingFailurePlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.EffingFailurePlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.EffingFailurePlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.EffingFailurePlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Terrarium":
                saveRoomStates.TerrariumPlanetUran = PlanetUran.Value;
                saveRoomStates.TerrariumPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.TerrariumPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.TerrariumPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.TerrariumPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.TerrariumPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.TerrariumPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.TerrariumPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Jupitwo":
                saveRoomStates.JupitwoPlanetUran = PlanetUran.Value;
                saveRoomStates.JupitwoPlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.JupitwoPlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.JupitwoPlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.JupitwoPlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.JupitwoPlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.JupitwoPlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.JupitwoPlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
            case "Orange":
                saveRoomStates.OrangePlanetUran = PlanetUran.Value;
                saveRoomStates.OrangePlanetChemikalien = PlanetChemikalien.Value;
                saveRoomStates.OrangePlanetWeltraumSchrott = PlanetWeltraumSchrott.Value;
                saveRoomStates.OrangePlanetMetallErz = PlanetMetallErz.Value;
                saveRoomStates.OrangePlanetLegierungen = PlanetLegierungen.Value;
                saveRoomStates.OrangePlanetMundspülung = PlanetMundspülung.Value;
                saveRoomStates.OrangePlanetZitronensäure = PlanetZitronensäure.Value;
                saveRoomStates.OrangePlanetTerraSchlangenGift = PlanetTerraSchlangenGift.Value;
                break;
        }
    }

    public void PlanetDrillStartClicked()
    {
        if (rohstoffLager == null) { rohstoffLager = FindAnyObjectByType<RohstoffLager>(); }
        if (rohstoffLager.currentMiningDrones.Value > 0 && isDrilling == false)
        {
            rohstoffLager.currentMiningDrones.Value--;
            isDrilling = true;
            StartCoroutine(StartDrill());
        }
        else if (isDrilling == true)
        {
            rohstoffLager.currentMiningDrones.Value++;
            isDrilling = false;
            drillProgress.Value = 0;
            StopAllCoroutines();
        }
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
        if (rohstoffLager == null) { rohstoffLager = FindAnyObjectByType<RohstoffLager>(); }
        drillProgress.Value = 0;

        while (drillProgress.Value < 100)
        {
            yield return new WaitForSeconds(0.8f);

            drillProgress.Value += rohstoffLager.speedOfDrills;
        }

        yield return new WaitForSeconds(0.2f);
        int random1 = Random.Range(1, rohstoffLager.discoveryChance);
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
