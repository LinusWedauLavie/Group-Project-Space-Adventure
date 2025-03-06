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
        ProduceRessources IcePlanetressources = IcePlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Icy";
        planetDescriptionText.text = "Die höchste auf Icy gemessene Temperatur beträgt -150 Grad Celsius, \nabgesehen von mikroorganismen im Wasser nahe des Planetenkerns unterstützt dieser Planet kaum leben. \nEinige Ungewöhnliche Rohstoffe sind hier zu finden.";
        planetRessourcessText.text = "Ressourcen: ";
        
        if (IcePlanetressources.PlanetUran > 0)
        {
            planetRessourcessText.text += "\n -Uran: " + IcePlanetressources.PlanetUran;
        }
        if (IcePlanetressources.PlanetChemikalien > 0)
        {
            planetRessourcessText.text += "\n -Chemikalien: " + IcePlanetressources.PlanetChemikalien;
        }
        if (IcePlanetressources.PlanetWeltraumSchrott > 0)
        {
            planetRessourcessText.text += "\n -WeltraumSchrott: " + IcePlanetressources.PlanetWeltraumSchrott;
        }
        if (IcePlanetressources.PlanetMetallErz > 0)
        {
            planetRessourcessText.text += "\n -MetallErz: " + IcePlanetressources.PlanetMetallErz;
        }
        if (IcePlanetressources.PlanetLegierungen > 0)
        {
            planetRessourcessText.text += "\n -Legierungen: " + IcePlanetressources.PlanetLegierungen;
        }
        if (IcePlanetressources.PlanetMundspülung > 0)
        {
            planetRessourcessText.text += "\n -Mundspülung: " + IcePlanetressources.PlanetMundspülung;
        }
        if (IcePlanetressources.PlanetZitronensäure > 0)
        {
            planetRessourcessText.text += "\n -Zitronensäure: " + IcePlanetressources.PlanetZitronensäure;
        }
        if (IcePlanetressources.PlanetTerraSchlangenGift > 0)
        {
            planetRessourcessText.text += "\n -TerraSchlangenGift: " + IcePlanetressources.PlanetTerraSchlangenGift;
        }

        planetInfoPanel.transform.position = new Vector3(IcePlanet.transform.position.x - 1.5f, IcePlanet.transform.position.y + 1.2f, 0);
    }

    public void ShowBlackholePlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources BlackholePlanetressources = BlackholePlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Blackhole";
        planetDescriptionText.text = "Blackhole Description";
        planetRessourcessText.text = "Blackhole Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(BlackholePlanet.transform.position.x + 1.5f, BlackholePlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowSunPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources SunPlanetressources = SunPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Sun";
        planetDescriptionText.text = "Sun Description";
        planetRessourcessText.text = "Sun Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(SunPlanet.transform.position.x - 1.5f, SunPlanet.transform.position.y + 1.2f, 0);
    }

    public void ShowBarenPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources BarenPlanetressources = BarenPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Baren Planet";
        planetDescriptionText.text = "Baren Planet Description";
        planetRessourcessText.text = "Baren Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(BarenPlanet.transform.position.x + 1.5f, BarenPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowLavaPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources LavaPlanetressources = LavaPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Lava Planet";
        planetDescriptionText.text = "Lava Planet Description";
        planetRessourcessText.text = "Lava Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(LavaPlanet.transform.position.x + 1.5f, LavaPlanet.transform.position.y + 1.2f, 0);
    }

    public void ShowTerranPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources TerranPlanetressources = TerranPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Terran Planet";
        planetDescriptionText.text = "Terran Planet Description";
        planetRessourcessText.text = "Terran Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(TerranPlanet.transform.position.x - 1.5f, TerranPlanet.transform.position.y + 1, 0);
    }

    public void ShowCrystalPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources CrystalPlanetressources = CrystalPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Crystal Planet";
        planetDescriptionText.text = "Crystal Planet Description";
        planetRessourcessText.text = "Crystal Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(CrystalPlanet.transform.position.x - 1.5f, CrystalPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowHotPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources HotPlanetressources = HotPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Hot Planet";
        planetDescriptionText.text = "Hot Planet Description";
        planetRessourcessText.text = "Hot Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(HotPlanet.transform.position.x + 1.5f, HotPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowIcyPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources IcyPlanetressources = IcyPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Icy Planet";
        planetDescriptionText.text = "Icy Planet Description";
        planetRessourcessText.text = "Icy Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(IcyPlanet.transform.position.x + 1.5f, IcyPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowRadiatedPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources RadiatedPlanetressources = RadiatedPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Radiated Planet";
        planetDescriptionText.text = "Radiated Planet Description";
        planetRessourcessText.text = "Radiated Planet " + "\n -Uran: " + RadiatedPlanetressources.PlanetUran;

        planetInfoPanel.transform.position = new Vector3(RadiatedPlanet.transform.position.x - 1.5f, RadiatedPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowTerrestrialPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources TerrestrialPlanetressources = TerrestrialPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Terrestrial Planet";
        planetDescriptionText.text = "Terrestrial Planet Description";
        planetRessourcessText.text = "Terrestrial Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(TerrestrialPlanet.transform.position.x - 1.5f, TerrestrialPlanet.transform.position.y - 1.2f, 0);
    }

    public void ShowJupiterPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        ProduceRessources JupiterPlanetressources = JupiterPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Jupiter Planet";
        planetDescriptionText.text = "Jupiter Planet Description";
        planetRessourcessText.text = "Jupiter Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(JupiterPlanet.transform.position.x + 1.5f, JupiterPlanet.transform.position.y + 1.2f, 0);
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
