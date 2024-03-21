using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class Slider_light : MonoBehaviour

{
    public Light2D globalLight;
    public Slider brightnessSlider,sfxSlider,scaleSlider; // Slider referans�

    void Start()
    {
        // Slider'�n de�isimini dinlemek i�in bir event ekleyin
        if(brightnessSlider!= null)brightnessSlider.onValueChanged.AddListener(ChangeBrightness);
        if (sfxSlider != null) sfxSlider.onValueChanged.AddListener(change_sfx);
    }

    // Slider de�eri de�i�tik�e �a�r�lacak fonksiyon
    public void ChangeBrightness(float value)
    {
        // I����n parlakl�k de�erini g�ncelle
        globalLight.intensity = value;
    }
    public void change_sfx(float value)
    {
        AudioListener.volume = value;
    }
    public void change_slider_sfx()
    {
        sfxSlider.value=AudioListener.volume;
    }
}


