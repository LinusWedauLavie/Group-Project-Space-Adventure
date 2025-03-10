using UnityEngine;
using UnityEngine.UI;

public class TesteScrolltext : MonoBehaviour
{
    public float i=0;
public void ChangeTransform()
{
    float j = FindAnyObjectByType<Scrollbar>().value;
    i = j*4;
    transform.position = new Vector3(960, -200.55f+ i*1500, 0);
}
}
