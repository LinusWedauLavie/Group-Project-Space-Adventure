using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class Terminal : MonoBehaviour, IPointerClickHandler
{
        private Image buttonImage;
        public Camera cam;
        Vector3 startCamPos;
 
    void Start()
    {
        buttonImage = GetComponent<Image>();
        startCamPos = cam.transform.position;
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        cam.transform.position = new Vector3(0, 3.7f, -6);
    }



}
