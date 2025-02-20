using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Terminal : MonoBehaviour
{
        private Image buttonImage;
        public GameObject forcefields;
        public Camera cam;

    public Transform startCamPos;
    public Transform targetTransform;
    public float transitionSpeed = 2.0f;
    public float maxZPosition = -5.0f;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        startCamPos = cam.transform;
    }
 
    public void ClickedTerminal()
    {
            StartCoroutine(OpenMap());
    }
    public void BackAwayFromPlanetMap()
    {
        

        StartCoroutine(CloseMap());
    }

    IEnumerator OpenMap()
    {
        yield return new WaitForEndOfFrame();


        Vector3 targetpos5less = new Vector3(0, targetTransform.position.y, targetTransform.position.z + maxZPosition);
        Vector3 newPosition = Vector3.Lerp(cam.transform.position, targetpos5less, Time.deltaTime * transitionSpeed);

        cam.transform.position = newPosition;
        cam.transform.rotation = Quaternion.Slerp(transform.rotation, targetTransform.rotation, Time.deltaTime * transitionSpeed);

        if (cam.transform.position.z < -5.8f)
        {
            StartCoroutine(OpenMap());
        }

    }

    IEnumerator CloseMap()
    {
        yield return new WaitForEndOfFrame();


        Vector3 targetpos5less = new Vector3(0, 0, startCamPos.position.z + maxZPosition+4);
        Vector3 newPosition = Vector3.Lerp(cam.transform.position, targetpos5less, Time.deltaTime * transitionSpeed);

        cam.transform.position = newPosition;
        cam.transform.rotation = Quaternion.Slerp(transform.rotation, startCamPos.rotation, Time.deltaTime * transitionSpeed);

        if (cam.transform.position.z > -13.8f)
        {
            StartCoroutine(CloseMap());
        }

    }
}
