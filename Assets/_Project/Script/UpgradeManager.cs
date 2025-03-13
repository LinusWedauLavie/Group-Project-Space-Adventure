using TMPro;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public RohstoffLager rohstoffLager;

    public TextMeshProUGUI discoveryChanceCostText, miningSpeedCostText, droneAmountCostText;

    int droneCost = 10;

    public void DiscoveryChanceUpgrade()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();

        switch (rohstoffLager.discoveryChance)
        {
            case 100:
                if (rohstoffLager.Uran.Value >= 20)
                {
                    rohstoffLager.Uran.Value -= 20;
                    rohstoffLager.discoveryChance = 70;
                    discoveryChanceCostText.text = "Ressourcenchance Upgrade \nKosten: 40 Uran";
                }
                break;
            case 70:
                if (rohstoffLager.Uran.Value >= 40)
                {
                    rohstoffLager.Uran.Value -= 40;
                    rohstoffLager.discoveryChance = 45;
                    discoveryChanceCostText.text = "Ressourcenchance Upgrade \nKosten: 60 Uran";
                }
                break;
            case 45:
                if (rohstoffLager.Uran.Value >= 60)
                {
                    rohstoffLager.Uran.Value -= 60;
                    rohstoffLager.discoveryChance = 20;
                    discoveryChanceCostText.text = "Ressourcenchance Upgrade \nMaximum erreicht";
                }
                break;
            default:
                break;
        }
    }

    public void MiningSpeedUpgrade()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();

        switch (rohstoffLager.speedOfDrills)
        {
            case 20:
                if (rohstoffLager.Chemikalien.Value >= 20)
                {
                    rohstoffLager.Chemikalien.Value -= 20;
                    rohstoffLager.speedOfDrills = 25;
                    miningSpeedCostText.text = "Abbaugeschwindigkeit Upgrade \nKosten: 40 Chemikalien";
                }
                break;
            case 25:
                if (rohstoffLager.Chemikalien.Value >= 40)
                {
                    rohstoffLager.Chemikalien.Value -= 40;
                    rohstoffLager.speedOfDrills = 35;
                    miningSpeedCostText.text = "Abbaugeschwindigkeit Upgrade \nKosten: 60 Chemikalien";
                }
                break;
            case 35:
                if (rohstoffLager.Chemikalien.Value >= 60)
                {
                    rohstoffLager.Chemikalien.Value -= 60;
                    rohstoffLager.speedOfDrills = 50;
                    miningSpeedCostText.text = "Abbaugeschwindigkeit Upgrade \nMaximum erreicht";
                }
                break;
            default:
                break;
        }
    }

    public void DroneAmountUpgrade()
    {
        rohstoffLager = FindAnyObjectByType<RohstoffLager>();

        if (rohstoffLager.MiningDrones.Value < 12)
        {
            if (rohstoffLager.Legierungen.Value >= droneCost)
            {
                rohstoffLager.Legierungen.Value -= droneCost;
                droneCost += 10;
                rohstoffLager.MiningDrones.Value += 1;
                if (rohstoffLager.MiningDrones.Value >= 12)
                {
                    droneAmountCostText.text = "Extra Drone Upgrade \nMaximum erreicht";
                }
                else
                {
                    droneAmountCostText.text = "Extra Drone Upgrade \nKosten: " + droneCost + " Legierungen";
                }
            }
        }
    }
}
