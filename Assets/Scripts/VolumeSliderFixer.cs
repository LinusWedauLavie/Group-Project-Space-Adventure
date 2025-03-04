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

        sauce.volume = au.volume;

        soundValue.Value = sauce.volume;

        slider.value = soundValue.Value;
    }

    void Update()
    {
        if (sauce == null || au == null)
        {
            sauce = FindAnyObjectByType<AudioSource>();
            au = FindAnyObjectByType<AudioManager>();
        }
        au.volume = slider.value;
        sauce.volume = slider.value;
    }
}
