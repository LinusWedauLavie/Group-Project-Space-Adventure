using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public RohstoffLager rohstoffLager;
    public void DiscoveryChanceUpgrade()
    {
        rohstoffLager =  FindAnyObjectByType<RohstoffLager>();

        if (rohstoffLager.discoveryChance > 20)
        {
            if (rohstoffLager.Uran.Value >= 20)
            {
                rohstoffLager.Uran.Value -= 20;
                if (rohstoffLager.discoveryChance == 100)
                { rohstoffLager.discoveryChance = 70; }
                else if (rohstoffLager.discoveryChance == 70)
                { rohstoffLager.discoveryChance = 45; }
                else if (rohstoffLager.discoveryChance == 45)
                { rohstoffLager.discoveryChance = 20; }
            }
        }
    }

    public void MiningSpeedUpgrade()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();

        if (rohstoffLager.speedOfDrills < 50)
        {
            if (rohstoffLager.Chemikalien.Value >= 20)
            {
                rohstoffLager.Chemikalien.Value -= 20;
                if (rohstoffLager.speedOfDrills == 20)
                { rohstoffLager.speedOfDrills = 25; }
                else if (rohstoffLager.speedOfDrills == 25)
                { rohstoffLager.speedOfDrills = 35; }
                else if (rohstoffLager.speedOfDrills == 35)
                { rohstoffLager.speedOfDrills = 50; }
            }
        }
    }

    public void DroneAmountUpgrade()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();

        if (rohstoffLager.MiningDrones.Value < 20)
        {
            if (rohstoffLager.Legierungen.Value >= 20)
            {
                rohstoffLager.Legierungen.Value -= 20;
                 rohstoffLager.MiningDrones.Value +=1;
            }
        }
    }

}
