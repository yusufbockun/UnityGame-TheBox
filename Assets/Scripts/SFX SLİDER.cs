using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    public Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = 0f;
        if (volumeSlider != null)
        {
            volumeSlider.onValueChanged.AddListener(ChangeVolume);
        }
    }

    // Fonksiyon, slider değeri değiştikçe çağrılır
    void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
