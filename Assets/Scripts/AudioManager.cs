using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using KBCore.Refs;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{
    static AudioManager instance;

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
