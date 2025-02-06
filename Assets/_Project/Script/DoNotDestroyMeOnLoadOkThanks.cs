using UnityEngine;

public class DoNotDestroyMeOnLoadOkThanks : MonoBehaviour
{
    static DoNotDestroyMeOnLoadOkThanks instance;
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
}
