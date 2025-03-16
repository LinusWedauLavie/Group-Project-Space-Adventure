using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static AudioManager instance;
    public float volume;

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
        volume = GetComponentInChildren<AudioSource>().volume;
    }

}
