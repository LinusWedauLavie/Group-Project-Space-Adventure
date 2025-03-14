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
        planetDescriptionText.text = "Ein schwarzes Loch in der Nähe der Space-Station.\n\n In der alten Zeit wurde es häufig als Friedhof einer unbekannten Spezies benutzt, wodurch es dort einiges an Schrott von kleineren Schiffen und unzählige Leichen gibt.";

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
        planetDescriptionText.text = "Eine riesige Orange die im Durchschnitt 5500C° warm ist. \nEinmal hat jemand probiert einen Bissen davon zu nehmen, leider ist er verbrannt, bevor er auch nur nah genug dran gehen konnte, deswegen ist der Geschmack der Orange immer noch ein Rätsel.";

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
        planetDescriptionText.text = "Der einst große Planet der Lämmer, jetzt nur noch eine leere Einöde. Der Planet war voller Lämmer bis auf einmal eine Alien-Spezies entschied diese aufgrund einer Prophezeiung auszulöschen. Es gibt Gerüchte von einem letzten Lamm mit einer großen Kraft.";

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
        planetDescriptionText.text = "Der 3. Lava Planet der jemals gefunden wurde. Alles auf ihm ist längst geschmolzen und hat sich mit der Lava assimiliert. Jedes Team, das den Planeten besucht hat ist verschwunden und nur die hitzeresistenzen Dronen schaffen es zurück.";

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
        planetDescriptionText.text = "Dieser Planet hat eine lange Geschichte an Traditionen und Lebewesen, doch wegen einem Geschehnis ist er heutzutage unbewohnbar. Auf ihm befinden sich einige schädliche Ressourcen, die sehr hilfreich sein können, wenn man sie mit Vorsicht behandelt.";

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
        planetDescriptionText.text = "Man sagt, dass dieser Planet für keine zwei Personen gleich aussieht. Sowohl der Planet als auch die Bewohner beherrschen die Kunst der Verkleidung und Täuschung. Er wird von den sogenannten „Masked Fools“ gesteuert, mit denen seit Jahren keiner Kontakt aufbauen konnte.";

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
        planetDescriptionText.text = "Für Ihre Schiffsindustrie und Zitronenanbau, sind die Laveateriner in der ganzen Galaxie bekannt. Niemand hat jemals einen Laveateriner gesehen oder nur mit ihnen gesprochen, wodurch verschiedene Theorien über sie existieren. Wahrscheinlich sind sie nur schüchtern.";

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
        planetDescriptionText.text = "Dieser Planet war früher für seine wilde Natur und Bewohner bekannt, doch nach der großen Lammvernichtung, hat sich dort ein anderes Klima aufgebaut. Es gibt Geschichten von einem Monster, der alles in seinem Wege umbringt oder versklavt. ";

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
        planetDescriptionText.text = "Effing Failure (früher „Mars“) war der Plan B der Menschheit. Leider hat der Leader aus „Amerika“ entschieden, zuerst an Atomkraft und ähnlichen Projekten zu arbeiten, die nicht mit dem lokalen Klima abgestimmt waren, wodurch der komplette Planet unbewohnbar wurde.";

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
        planetDescriptionText.text = "Den Planet umgibt eine riesige, unsichtbare Glasscheibe mit einzelnen Vacuumlöchern. Auf ihm lebt eine Spezies namens „Dinosaurier“. Diese sind vor Millionen von Jahren von Terra geflohen, da ihr Satellitensystem einen unausweichbaren Meteoriten entdeckt haben.";

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
        planetDescriptionText.text = "Nachdem der Originale Planet „Jupiter“ als Zwergplanet eingestuft wurde, haben sich einige Spezies zusammengetan um einen neuen und verbesserten Jupiter zu bauen. Durch Ressourcensammlung wurde der Originale Jupiter zerstört und Jupitwo ist der letzte Beweis dessen Existenz.";

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
