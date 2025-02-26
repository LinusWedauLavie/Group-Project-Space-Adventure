using TMPro;
using UnityEngine;

public class PlanetInfoPanelManager : MonoBehaviour
{


    public GameObject planetInfoPanel, IcePlanet, BlackholePlanet, SunPlanet, BarenPlanet, LavaPlanet, TerranPlanet, CrystalPlanet, HotPlanet, IcyPlanet, RadiatedPlanet, TerrestrialPlanet, JupiterPlanet;
    
    public TextMeshProUGUI planetTextHeader , planetDescriptionText, planetRessourcessText, planetTextPlaceholderOne, planetTextPlaceholderTwo, planetTextPlaceholderThree;

    public void ShowIcePlanetStats()
    {
        ProduceRessources IcePlanetressources = IcePlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Ice Planet";
        planetDescriptionText.text= "Ice Planet Description";
        planetRessourcessText.text= "Ice Planet: " + "-Chemikalien: " + IcePlanetressources.Chemikalien.Value; //" + "\n Uran: " + produceRessources.Uran.Value + "\n Chemikalien: " + produceRessources.Chemikalien.Value;

        planetInfoPanel.transform.position = new Vector3(IcePlanet.transform.position.x-1.5f, IcePlanet.transform.position.y+1.2f, 0);
    }
    
    public void ShowBlackholePlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Blackhole";
        planetDescriptionText.text= "Blackhole Description";
        planetRessourcessText.text= "Blackhole Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(BlackholePlanet.transform.position.x+1.5f, BlackholePlanet.transform.position.y-1.2f, 0);
    }

    public void ShowSunPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Sun";
        planetDescriptionText.text= "Sun Description";
        planetRessourcessText.text= "Sun Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(SunPlanet.transform.position.x-1.5f, SunPlanet.transform.position.y+1.2f, 0);
    }

    public void ShowBarenPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Baren Planet";
        planetDescriptionText.text= "Baren Planet Description";
        planetRessourcessText.text= "Baren Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(BarenPlanet.transform.position.x+1.5f, BarenPlanet.transform.position.y-1.2f, 0);
    }

    public void ShowLavaPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Lava Planet";
        planetDescriptionText.text= "Lava Planet Description";
        planetRessourcessText.text= "Lava Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(LavaPlanet.transform.position.x+1.5f, LavaPlanet.transform.position.y+1.2f, 0);
    }

    public void ShowTerranPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Terran Planet";
        planetDescriptionText.text= "Terran Planet Description";
        planetRessourcessText.text= "Terran Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(TerranPlanet.transform.position.x-1.5f, TerranPlanet.transform.position.y+1, 0);
    }

    public void ShowCrystalPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Crystal Planet";
        planetDescriptionText.text= "Crystal Planet Description";
        planetRessourcessText.text= "Crystal Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(CrystalPlanet.transform.position.x-1.5f, CrystalPlanet.transform.position.y-1.2f, 0);
    }

        public void ShowHotPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Hot Planet";
        planetDescriptionText.text= "Hot Planet Description";
        planetRessourcessText.text= "Hot Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(HotPlanet.transform.position.x+1.5f, HotPlanet.transform.position.y-1.2f, 0);
    }

    public void ShowIcyPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Icy Planet";
        planetDescriptionText.text= "Icy Planet Description";
        planetRessourcessText.text= "Icy Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(IcyPlanet.transform.position.x+1.5f, IcyPlanet.transform.position.y-1.2f, 0);
    }

    public void ShowRadiatedPlanetStats()
    {
ProduceRessources RadiatedPlanetressources = RadiatedPlanet.GetComponent<ProduceRessources>();

        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Radiated Planet";
        planetDescriptionText.text= "Radiated Planet Description";
        planetRessourcessText.text= "Radiated Planet " + "\n -Uran: " + RadiatedPlanetressources.Uran.Value;

        planetInfoPanel.transform.position = new Vector3(RadiatedPlanet.transform.position.x-1.5f, RadiatedPlanet.transform.position.y-1.2f, 0);
    }

    public void ShowTerrestrialPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Terrestrial Planet";
        planetDescriptionText.text= "Terrestrial Planet Description";
        planetRessourcessText.text= "Terrestrial Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(TerrestrialPlanet.transform.position.x-1.5f, TerrestrialPlanet.transform.position.y-1.2f, 0);
    }

    public void ShowJupiterPlanetStats()
    {
        planetInfoPanel.SetActive(true);
        planetTextHeader.text= "Jupiter Planet";
        planetDescriptionText.text= "Jupiter Planet Description";
        planetRessourcessText.text= "Jupiter Planet Eisen oder so: 100";

        planetInfoPanel.transform.position = new Vector3(JupiterPlanet.transform.position.x+1.5f, JupiterPlanet.transform.position.y+1.2f, 0);
    }
    public void HidePlanetStats()
    {
        planetInfoPanel.SetActive(false);
    }
}
