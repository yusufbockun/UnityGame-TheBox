using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class Slider_light : MonoBehaviour

{
    public Light2D globalLight;
    public Slider brightnessSlider,sfxSlider,scaleSlider; // Slider referansý

    void Start()
    {
        // Slider'ýn deðisimini dinlemek için bir event ekleyin
        if(brightnessSlider!= null)brightnessSlider.onValueChanged.AddListener(ChangeBrightness);
        if (sfxSlider != null) sfxSlider.onValueChanged.AddListener(change_sfx);
    }

    // Slider deðeri deðiþtikçe çaðrýlacak fonksiyon
    public void ChangeBrightness(float value)
    {
        // Iþýðýn parlaklýk deðerini güncelle
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


