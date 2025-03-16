using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveRoomStates : MonoBehaviour
{
    static SaveRoomStates instance;

    //Room bool's damit die räume nur eine Aufgabe ihren State laden
    public bool cryoCompletedSave, cabineCompletedSave;

    //Für Cryo
    public bool firstLoad = true;

    //Collectables
    public bool coinCryoCollected, coinCanteenCollected, coinLabCollected, coinMedbayCollected, coinBridgeCollected; //mehr coins hier))
    public int memoryCards; //Menge an karten die gesammelt wurden
    public bool cabinesMemCardCollected, canteenMemoryCardCollected, labMemCardCollected, medbayMemCardCollected, hangarMemCardCollected, bridgeMemCardCollected; //memorycards 
    public bool sickleCollected, sicklePlaced, hammerCollected, hammerPlaced, scanDone; //Medbay minigame 
    public int medbayCommieCount, coinsInVendingMachine, labLevel; //Medbay sichel und hammer zähler, und coins in vending machine und lab level counter
    public bool cabinesMapCollected, medbayMapCollected, theStorageMapCollected, cabinesMapPlaced, medbayMapPlaced, theStorageMapPlaced, LabMiniGameRigthSolution, LabRecipeRightSolutionTop, LabRecipeRightSolutionMid, LabRecipeRightSolutionBottom, pickedUpPotion, brokeVent; //lab minigame items und anderes
    public bool medbayScan, firstCollectedResource;

    public float GoatsGrandMawPlanetUran, GoatsGrandMawPlanetChemikalien, GoatsGrandMawPlanetWeltraumSchrott, GoatsGrandMawPlanetMetallErz, GoatsGrandMawPlanetLegierungen, GoatsGrandMawPlanetMundspülung, GoatsGrandMawPlanetZitronensäure, GoatsGrandMawPlanetTerraSchlangenGift;
    public float DeltaLambtauriPlanetUran, DeltaLambtauriPlanetChemikalien, DeltaLambtauriPlanetWeltraumSchrott, DeltaLambtauriPlanetMetallErz, DeltaLambtauriPlanetLegierungen, DeltaLambtauriPlanetMundspülung, DeltaLambtauriPlanetZitronensäure, DeltaLambtauriPlanetTerraSchlangenGift;
    public float IcyPlanetUran, IcyPlanetChemikalien, IcyPlanetWeltraumSchrott, IcyPlanetMetallErz, IcyPlanetLegierungen, IcyPlanetMundspülung, IcyPlanetZitronensäure, IcyPlanetTerraSchlangenGift;
    public float X03MoltenPlanetUran, X03MoltenPlanetChemikalien, X03MoltenPlanetWeltraumSchrott, X03MoltenPlanetMetallErz, X03MoltenPlanetLegierungen, X03MoltenPlanetMundspülung, X03MoltenPlanetZitronensäure, X03MoltenPlanetTerraSchlangenGift;
    public float VerfluchterTerranPlanetUran, VerfluchterTerranPlanetChemikalien, VerfluchterTerranPlanetWeltraumSchrott, VerfluchterTerranPlanetMetallErz, VerfluchterTerranPlanetLegierungen, VerfluchterTerranPlanetMundspülung, VerfluchterTerranPlanetZitronensäure, VerfluchterTerranPlanetTerraSchlangenGift;
    public float GreatSparklePlanetUran, GreatSparklePlanetChemikalien, GreatSparklePlanetWeltraumSchrott, GreatSparklePlanetMetallErz, GreatSparklePlanetLegierungen, GreatSparklePlanetMundspülung, GreatSparklePlanetZitronensäure, GreatSparklePlanetTerraSchlangenGift;
    public float LavaeaterPlanetUran, LavaeaterPlanetChemikalien, LavaeaterPlanetWeltraumSchrott, LavaeaterPlanetMetallErz, LavaeaterPlanetLegierungen, LavaeaterPlanetMundspülung, LavaeaterPlanetZitronensäure, LavaeaterPlanetTerraSchlangenGift;
    public float StormEPlanetUran, StormEPlanetChemikalien, StormEPlanetWeltraumSchrott, StormEPlanetMetallErz, StormEPlanetLegierungen, StormEPlanetMundspülung, StormEPlanetZitronensäure, StormEPlanetTerraSchlangenGift;
    public float EffingFailurePlanetUran, EffingFailurePlanetChemikalien, EffingFailurePlanetWeltraumSchrott, EffingFailurePlanetMetallErz, EffingFailurePlanetLegierungen, EffingFailurePlanetMundspülung, EffingFailurePlanetZitronensäure, EffingFailurePlanetTerraSchlangenGift;
    public float TerrariumPlanetUran, TerrariumPlanetChemikalien, TerrariumPlanetWeltraumSchrott, TerrariumPlanetMetallErz, TerrariumPlanetLegierungen, TerrariumPlanetMundspülung, TerrariumPlanetZitronensäure, TerrariumPlanetTerraSchlangenGift;
    public float JupitwoPlanetUran, JupitwoPlanetChemikalien, JupitwoPlanetWeltraumSchrott, JupitwoPlanetMetallErz, JupitwoPlanetLegierungen, JupitwoPlanetMundspülung, JupitwoPlanetZitronensäure, JupitwoPlanetTerraSchlangenGift;
    public float OrangePlanetUran, OrangePlanetChemikalien, OrangePlanetWeltraumSchrott, OrangePlanetMetallErz, OrangePlanetLegierungen, OrangePlanetMundspülung, OrangePlanetZitronensäure, OrangePlanetTerraSchlangenGift;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            {

#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
                Application.Quit();
            }
        }
    }

    public void GetRoomState()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Bridge":
                memoryCards = FindAnyObjectByType<Ki_MemoryCard>().memoryCards;
                break;
            case "Cabines":
                cabineCompletedSave = FindAnyObjectByType<SimonSays>().done;
                break;
            case "Canteen":

                break;
            case "Cryo":
                cryoCompletedSave = FindAnyObjectByType<MoveObjectLeft>().hasMoved;
                firstLoad = false;
                break;
            case "Hangar":

                break;
            case "Lab":

                GameObject labTop = GameObject.Find("labPaperTop");
                if (labTop.GetComponent<LabMiniGameRecipe>().rightSolutionTop == true)
                {
                    LabRecipeRightSolutionTop = labTop.GetComponent<LabMiniGameRecipe>().rightSolutionTop;
                }
                GameObject labMid = GameObject.Find("labPaperMid");
                if (labMid.GetComponent<LabMiniGameRecipe>().rightSolutionMid == true)
                {
                    LabRecipeRightSolutionMid = labMid.GetComponent<LabMiniGameRecipe>().rightSolutionMid;
                }

                GameObject labBottom = GameObject.Find("labPaperBottom");
                if (labBottom.GetComponent<LabMiniGameRecipe>().rightSolutionBottom == true)
                {
                    LabRecipeRightSolutionBottom = labBottom.GetComponent<LabMiniGameRecipe>().rightSolutionBottom;
                }

                LabMiniGameRigthSolution = FindAnyObjectByType<LabMiniGame>().rightSolution;
                labLevel = FindAnyObjectByType<LabMiniGame>().level;


                break;
            case "Medbay":
                medbayCommieCount = FindAnyObjectByType<MedbayScan>().communism;
                scanDone = FindAnyObjectByType<MedbayScan>().scanDone;

                GameObject hammer = GameObject.Find("Hammer");
                if (hammer.GetComponent<MedbayCommie>().hammerPlaced == true)
                {
                    hammerPlaced = hammer.GetComponent<MedbayCommie>().hammerPlaced;
                }

                GameObject sickle = GameObject.Find("Sichel");
                if (sickle.GetComponent<MedbayCommie>().sicklePlaced == true)
                {
                    sicklePlaced = sickle.GetComponent<MedbayCommie>().sicklePlaced;
                }

                break;
            case "TheStorage":

                break;
            default:
                //Debug.Log("Saveroomstate konnte den Raum nicht speichern, weil der Raum nicht gefunden wurde!");
                break;
        }
    }
}
