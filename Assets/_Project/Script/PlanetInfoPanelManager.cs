using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlanetInfoPanelManager : MonoBehaviour
{
    public GameObject planetInfoPanel, ActivateTerminalButton, GoBackFromMapButton, IcePlanet, BlackholePlanet, SunPlanet, BarenPlanet, LavaPlanet, TerranPlanet, CrystalPlanet, HotPlanet, IcyPlanet, RadiatedPlanet, TerrestrialPlanet, JupiterPlanet;

    public TextMeshProUGUI planetTextHeader, planetDescriptionText, planetRessourcessText, planetTextPlaceholderOne, planetTextPlaceholderTwo, planetTextPlaceholderThree;

    public void ShowIcePlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = IcePlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Icy";
        planetDescriptionText.text = "Die höchste auf Icy gemessene Temperatur beträgt -150 Grad Celsius, \nabgesehen von mikroorganismen im Wasser nahe des Planetenkerns unterstützt dieser Planet kaum leben. \nEinige Ungewöhnliche Rohstoffe sind hier zu finden.";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(IcePlanet.transform.position.x - 1.5f, IcePlanet.transform.position.y + 1.2f, 0);
    }

    public void ShowBlackholePlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = BlackholePlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Goats Grand Maw";
        planetDescriptionText.text = "Blackhole Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(BlackholePlanet.transform.position.x + 1.5f, BlackholePlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowSunPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = SunPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Orange";
        planetDescriptionText.text = "Sun Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(SunPlanet.transform.position.x - 1.5f, SunPlanet.transform.position.y + 1.2f, 0);
    }

    public void ShowBarenPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = BarenPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Delta Lambtauri";
        planetDescriptionText.text = "Baren Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(BarenPlanet.transform.position.x + 1.5f, BarenPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowLavaPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = LavaPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "X-03 Molten";
        planetDescriptionText.text = "Lava Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(LavaPlanet.transform.position.x + 1.5f, LavaPlanet.transform.position.y + 1.2f, 0);
    }

    public void ShowTerranPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = TerranPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Verfluchter Terran";
        planetDescriptionText.text = "Terran Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(TerranPlanet.transform.position.x - 1.5f, TerranPlanet.transform.position.y + 1, 0);
    }

    public void ShowCrystalPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = CrystalPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Great Sparkle";
        planetDescriptionText.text = "Crystal Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(CrystalPlanet.transform.position.x - 1.5f, CrystalPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowHotPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = HotPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Lavaeater";
        planetDescriptionText.text = "Hot Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(HotPlanet.transform.position.x + 1.5f, HotPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowIcyPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = IcyPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Storm E";
        planetDescriptionText.text = "Icy Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(IcyPlanet.transform.position.x + 1.5f, IcyPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowRadiatedPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = RadiatedPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Effing Failure";
        planetDescriptionText.text = "Radiated Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(RadiatedPlanet.transform.position.x - 1.5f, RadiatedPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowTerrestrialPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = TerrestrialPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Terrarium";
        planetDescriptionText.text = "Terrestrial Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(TerrestrialPlanet.transform.position.x - 1.5f, TerrestrialPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowJupiterPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources Planetressources = JupiterPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Jupitwo";
        planetDescriptionText.text = "Jupiter Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(JupiterPlanet.transform.position.x + 1.5f, JupiterPlanet.transform.position.y + 1.2f, 0);
    }

    private void ShowRessources(ProduceRessources Planetressources)
    {
        planetRessourcessText.text = "Ressourcen: ";
        if (Planetressources.PlanetUran > 0)
        {
            planetRessourcessText.text += "\n -Uran: " + Planetressources.PlanetUran;
        }
        if (Planetressources.PlanetChemikalien > 0)
        {
            planetRessourcessText.text += "\n -Chemikalien: " + Planetressources.PlanetChemikalien;
        }
        if (Planetressources.PlanetWeltraumSchrott > 0)
        {
            planetRessourcessText.text += "\n -WeltraumSchrott: " + Planetressources.PlanetWeltraumSchrott;
        }
        if (Planetressources.PlanetMetallErz > 0)
        {
            planetRessourcessText.text += "\n -MetallErz: " + Planetressources.PlanetMetallErz;
        }
        if (Planetressources.PlanetLegierungen > 0)
        {
            planetRessourcessText.text += "\n -Legierungen: " + Planetressources.PlanetLegierungen;
        }
        if (Planetressources.PlanetMundspülung > 0)
        {
            planetRessourcessText.text += "\n -Mundspülung: " + Planetressources.PlanetMundspülung;
        }
        if (Planetressources.PlanetZitronensäure > 0)
        {
            planetRessourcessText.text += "\n -Zitronensäure: " + Planetressources.PlanetZitronensäure;
        }
        if (Planetressources.PlanetTerraSchlangenGift > 0)
        {
            planetRessourcessText.text += "\n -TerraSchlangenGift: " + Planetressources.PlanetTerraSchlangenGift;
        }
    }


    public void HidePlanetStats()
    {
        planetInfoPanel.SetActive(false);
    }

    bool TerminalIsNOTActive()
    {
        if (ActivateTerminalButton.GetComponent<Button>().enabled == true || GoBackFromMapButton.GetComponent<Button>().enabled == false)
        {
            return true;
        }
        return false;
    }
}
