using Unity.VisualScripting;
using UnityEngine;

public class SmoothCameraTransition : MonoBehaviour
{
    public Transform targetTransform;
    public float transitionSpeed = 2.0f;
    public float maxZPosition = -5.0f;
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (targetTransform == null || cam == null) return;

        Vector3 targetpos5less = new Vector3(targetTransform.position.x, targetTransform.position.y, targetTransform.position.z + maxZPosition);
        Vector3 newPosition = Vector3.Lerp(transform.position, targetpos5less, Time.deltaTime * transitionSpeed);

        transform.position = newPosition;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetTransform.rotation, Time.deltaTime * transitionSpeed);
    }
}

/*
 * using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class Terminal : MonoBehaviour, IPointerClickHandler
{
        private Image buttonImage;
        public Camera cam;
        Vector3 startCamPos;

    public Transform targetTransform;
    public float transitionSpeed = 2.0f;
    public float maxZPosition = -5.0f;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        startCamPos = cam.transform.position;
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        if (targetTransform == null || cam == null) return;

        Vector3 targetpos5less = new Vector3(targetTransform.position.x, targetTransform.position.y, targetTransform.position.z + maxZPosition);
        Vector3 newPosition = Vector3.Lerp(transform.position, targetpos5less, Time.deltaTime * transitionSpeed);

        transform.position = newPosition;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetTransform.rotation, Time.deltaTime * transitionSpeed);
    }

}


 * */