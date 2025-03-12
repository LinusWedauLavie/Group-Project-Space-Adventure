using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlanetInfoPanelManager : MonoBehaviour
{
    public GameObject planetInfoPanel, ActivateTerminalButton, GoBackFromMapButton, DroneInfoPanel, IcePlanet, BlackholePlanet, SunPlanet, BarenPlanet, LavaPlanet, TerranPlanet, CrystalPlanet, HotPlanet, IcyPlanet, RadiatedPlanet, TerrestrialPlanet, JupiterPlanet;

    public TextMeshProUGUI planetTextHeader, planetDescriptionText, planetRessourcessText;

    public ProduceRessources Planetressources;

    RohstoffLager rohstoffLager;
    public void ShowIcePlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = IcePlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Icy";
        planetDescriptionText.text = "Die höchste auf Icy gemessene Temperatur beträgt -150 Grad Celsius, \nabgesehen von mikroorganismen im Wasser nahe des Planetenkerns unterstützt dieser Planet kaum leben. \nEinige Ungewöhnliche Rohstoffe sind hier zu finden.";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(IcePlanet.transform.position.x - 1.5f, IcePlanet.transform.position.y + 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += -1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowBlackholePlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = BlackholePlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Goats Grand Maw";
        planetDescriptionText.text = "Blackhole Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(BlackholePlanet.transform.position.x + 1.5f, BlackholePlanet.transform.position.y - 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += 1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowSunPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = SunPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Orange";
        planetDescriptionText.text = "Sun Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(SunPlanet.transform.position.x - 1.5f, SunPlanet.transform.position.y + 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += -1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowBarenPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = BarenPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Delta Lambtauri";
        planetDescriptionText.text = "Baren Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(BarenPlanet.transform.position.x + 1.5f, BarenPlanet.transform.position.y - 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += 1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowLavaPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = LavaPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "X-03 Molten";
        planetDescriptionText.text = "Lava Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(LavaPlanet.transform.position.x + 1.5f, LavaPlanet.transform.position.y + 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += 1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowTerranPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = TerranPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Verfluchter Terran";
        planetDescriptionText.text = "Terran Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(TerranPlanet.transform.position.x - 1.5f, TerranPlanet.transform.position.y + 1, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += -1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowCrystalPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = CrystalPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Great Sparkle";
        planetDescriptionText.text = "Crystal Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(CrystalPlanet.transform.position.x - 1.5f, CrystalPlanet.transform.position.y - 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += -1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowHotPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = HotPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Lavaeater";
        planetDescriptionText.text = "Hot Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(HotPlanet.transform.position.x + 1.5f, HotPlanet.transform.position.y - 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += 1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowIcyPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = IcyPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Storm E";
        planetDescriptionText.text = "Icy Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(IcyPlanet.transform.position.x + 1.5f, IcyPlanet.transform.position.y - 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += 1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowRadiatedPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = RadiatedPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Effing Failure";
        planetDescriptionText.text = "Radiated Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(RadiatedPlanet.transform.position.x - 1.5f, RadiatedPlanet.transform.position.y - 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += -1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowTerrestrialPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = TerrestrialPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Terrarium";
        planetDescriptionText.text = "Terrestrial Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(TerrestrialPlanet.transform.position.x - 1.5f, TerrestrialPlanet.transform.position.y - 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += -1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowJupiterPlanetStats()
    {
        if (TerminalIsNOTActive())
        {
            return;
        }
        Planetressources = JupiterPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text = "Jupitwo";
        planetDescriptionText.text = "Jupiter Planet Description";

        ShowRessources(Planetressources);

        planetInfoPanel.transform.position = new Vector3(JupiterPlanet.transform.position.x + 1.5f, JupiterPlanet.transform.position.y + 1.2f, 0);
        Vector3 newPosition = DroneInfoPanel.transform.position;
        newPosition.x = GetComponentInParent<Transform>().transform.position.x;
        newPosition.x += 1.85435f;
        DroneInfoPanel.transform.position = newPosition;

        rohstoffLager = FindAnyObjectByType<RohstoffLager>();
        rohstoffLager.UpdateDronesInStorage();
    }

    public void ShowRessources(ProduceRessources Planetressources)
    {
        planetRessourcessText.text = "Ressourcen: ";
        if (Planetressources.PlanetUran.Value > 0)
        {
            planetRessourcessText.text += "\n -Uran: " + Planetressources.PlanetUran.Value;
        }
        if (Planetressources.PlanetChemikalien.Value > 0)
        {
            planetRessourcessText.text += "\n -Chemikalien: " + Planetressources.PlanetChemikalien.Value;
        }
        if (Planetressources.PlanetWeltraumSchrott.Value > 0)
        {
            planetRessourcessText.text += "\n -WeltraumSchrott: " + Planetressources.PlanetWeltraumSchrott.Value;
        }
        if (Planetressources.PlanetMetallErz.Value > 0)
        {
            planetRessourcessText.text += "\n -MetallErz: " + Planetressources.PlanetMetallErz.Value;
        }
        if (Planetressources.PlanetLegierungen.Value > 0)
        {
            planetRessourcessText.text += "\n -Legierungen: " + Planetressources.PlanetLegierungen.Value;
        }
        if (Planetressources.PlanetMundspülung.Value > 0)
        {
            planetRessourcessText.text += "\n -Mundspülung: " + Planetressources.PlanetMundspülung.Value;
        }
        if (Planetressources.PlanetZitronensäure.Value > 0)
        {
            planetRessourcessText.text += "\n -Zitronensäure: " + Planetressources.PlanetZitronensäure.Value;
        }
        if (Planetressources.PlanetTerraSchlangenGift.Value > 0)
        {
            planetRessourcessText.text += "\n -TerraSchlangenGift: " + Planetressources.PlanetTerraSchlangenGift.Value;
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
