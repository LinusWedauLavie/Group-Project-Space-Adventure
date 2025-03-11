using UnityEngine;
using UnityEngine.UI;

public class Scrolltext : MonoBehaviour
{
public float i = 0;
[SerializeField] public float slay = 150;

public void ChangeTransform()
{
    float j = FindAnyObjectByType<Scrollbar>().value;
    i = j*4;
    transform.position = new Vector3(970, 967.1138f + i*slay, 0);
}
}
