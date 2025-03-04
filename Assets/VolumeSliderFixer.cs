using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderFixer : MonoBehaviour
{

    public AudioManager au;
    public Slider slider;
    public AudioSource sauce;
    [SerializeField] public Observable<float> soundValue;

    void Start()
    {
        au = FindAnyObjectByType<AudioManager>();
        slider = FindAnyObjectByType<Slider>();
        sauce = FindAnyObjectByType<AudioSource>();

        slider.value = soundValue.Value;
    }

    void Update()
    {
        if (sauce == null || au == null)
        {
            sauce = FindAnyObjectByType<AudioSource>();
            au = FindAnyObjectByType<AudioManager>();
        }

        sauce.volume = slider.value;
    }
}
