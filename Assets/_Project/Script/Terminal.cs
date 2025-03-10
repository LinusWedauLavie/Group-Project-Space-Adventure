using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Terminal : MonoBehaviour
{

    public SpriteRenderer forcefieldRendererUp, forcefieldRendererDown;

    Color color;
    Color normalColor;

    public float alphaValue = 0.33f; //beim anderen 0.03 oder so

    public Camera cam;
    public GameObject UpgradesPanel;

    Transform startCamPos;
    public Transform targetTransform;
    public float transitionSpeed = 2.0f;
    public float maxZPosition = -5.0f;
    public float StartCamSize = 8;
    public float LowestCamSize = 3.2f;


    public GameObject GoBackFromMapButton, GoBackFromMapButtonArrows, ActivateTerminalButton;

    void Start()
    {
        startCamPos = cam.transform;
        normalColor = forcefieldRendererUp.color;

    }

    public void ClickedTerminal()
    {
        color = normalColor;
        alphaValue = 0.33f;
        ActivateTerminalButton.GetComponent<Button>().enabled = false;
        StartCoroutine(OpenMap());
    }
    public void BackAwayFromPlanetMap()
    {

        color = normalColor;
        alphaValue = 0.03f;
        GoBackFromMapButtonArrows.SetActive(false);
        GoBackFromMapButton.GetComponent<Button>().enabled = false;
        UpgradesPanel.SetActive(false);
        StartCoroutine(CloseMap());
    }

    IEnumerator OpenMap()
    {
        yield return new WaitForEndOfFrame();


        Vector3 targetpos5less = new Vector3(0, targetTransform.position.y, targetTransform.position.z + maxZPosition);
        Vector3 newPosition = Vector3.Lerp(cam.transform.position, targetpos5less, Time.deltaTime * transitionSpeed);

        cam.orthographicSize += (LowestCamSize - cam.orthographicSize) * (Time.deltaTime * transitionSpeed);


        cam.transform.position = newPosition;
        cam.transform.rotation = Quaternion.Slerp(transform.rotation, targetTransform.rotation, Time.deltaTime * transitionSpeed);

        if (alphaValue > 0.03f)
        {
            alphaValue -= 0.005f;
            color.a = alphaValue;
            forcefieldRendererUp.color = color;
            forcefieldRendererDown.color = color;
        }
        else
        {
            alphaValue = 0.03f;
        }

        if (cam.transform.position.z < -5.8f)
        {
            StartCoroutine(OpenMap());
        }
        else
        {
            GoBackFromMapButton.SetActive(true);
            GoBackFromMapButtonArrows.SetActive(true);
            GoBackFromMapButton.GetComponent<Button>().enabled = true;
            UpgradesPanel.SetActive(true);

        }

    }

    IEnumerator CloseMap()
    {
        yield return new WaitForEndOfFrame();


        Vector3 targetpos5less = new Vector3(0, 0, startCamPos.position.z + maxZPosition + 4);
        Vector3 newPosition = Vector3.Lerp(cam.transform.position, targetpos5less, Time.deltaTime * transitionSpeed);

        cam.orthographicSize += (StartCamSize - cam.orthographicSize) * (Time.deltaTime * transitionSpeed);

        cam.transform.position = newPosition;
        cam.transform.rotation = Quaternion.Slerp(transform.rotation, startCamPos.rotation, Time.deltaTime * transitionSpeed);


        if (color.a < 0.33f)
        {
            alphaValue += 0.005f;
            color.a = alphaValue;
            forcefieldRendererUp.color = color;
            forcefieldRendererDown.color = color;
        }
        else
        {
            alphaValue = 0.33f;
        }

        if (cam.transform.position.z > -13.8f)
        {
            StartCoroutine(CloseMap());
        }
        else
        {
            GoBackFromMapButton.SetActive(false);
            ActivateTerminalButton.GetComponent<Button>().enabled = true;
        }

    }
}
