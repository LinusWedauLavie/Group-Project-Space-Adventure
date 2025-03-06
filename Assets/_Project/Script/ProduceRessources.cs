using System.Collections;
using UnityEngine;

public class ProduceRessources : MonoBehaviour
{
 public float PlanetUran, PlanetChemikalien, PlanetWeltraumSchrott, PlanetMetallErz, PlanetLegierungen, PlanetMundspülung, PlanetZitronensäure, PlanetTerraSchlangenGift; //Spawnchancen für die Rohstoffe

    RohstoffLager rohstoffLager;

    private void Start()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
    }

    public void PlanetDrillStartClicked()
    {
        if (rohstoffLager.miningDrones>0)
        {
            rohstoffLager.miningDrones--;
            StartCoroutine(StartDrill());
        }
    }

    IEnumerator StartDrill()
    {
        int random1 = Random.Range(1, 100);
        if (random1 <= PlanetUran)
        {
            PlanetUran--;
            rohstoffLager.Uran.Value++;
        }
        if (random1 <= PlanetChemikalien)
        {
            PlanetChemikalien--;
            rohstoffLager.Chemikalien.Value++;
        }
        if (random1 <= PlanetWeltraumSchrott)
        {
            PlanetWeltraumSchrott--;
            rohstoffLager.WeltraumSchrott.Value++;
        }
        if (random1 <= PlanetMetallErz)
        {
            PlanetMetallErz--;
            rohstoffLager.MetallErz.Value++;
        }
        if (random1 <= PlanetLegierungen)
        {  
            PlanetLegierungen--;
            rohstoffLager.Legierungen.Value++;
        }
        if (random1 <= PlanetMundspülung)
        {
            PlanetMundspülung--;
            rohstoffLager.Mundspülung.Value++;
        }
        if (random1 <= PlanetZitronensäure)
        {
            PlanetZitronensäure--;
            rohstoffLager.Zitronensäure.Value++;
        }
        if (random1 <= PlanetTerraSchlangenGift)
        {
            PlanetTerraSchlangenGift--;
            rohstoffLager.TerraSchlangenGift.Value++;
        }

        yield return new WaitForSeconds(3);
        StartCoroutine(StartDrill());
    }
}
