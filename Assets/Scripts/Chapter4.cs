using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DoorScript : MonoBehaviour
{

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    private int ButtonIndex = 0;


    

    private void Start()
    {
        button1.onClick.AddListener(() => CheckButtonPress(1));
        
        button2.onClick.AddListener(() => CheckButtonPress(2));
        button3.onClick.AddListener(() => CheckButtonPress(3));
        button4.onClick.AddListener(() => CheckButtonPress(4));
    }
    private void Update()
    {

    }

    void CheckButtonPress(int expectedButtonIndex)
    {
        // Oyuncunun doğru sırayla butona basıp basmadığını kontrol et
        Debug.Log("yess");
        if (expectedButtonIndex == ButtonIndex + 1)
        {
            // Doğru sırayla butona basıldı
            ButtonIndex++;

            // Tüm butonlara basıldıysa oyunu sıfırla
            if (ButtonIndex == 1)
            {
                ButtonIndex++;
                if (ButtonIndex == 2)
                {
                    ButtonIndex++;
                    if(ButtonIndex == 4)
                    {
                        ButtonIndex = 0;
                        Debug.Log("Oyun tamamlandı. Yeni oyun başlıyor."); 
                    }
                    else
                    {
                        ButtonIndex = 0;
                        Debug.Log("Yanlış butona basıldı. Oyun sıfırlandı.");
                    }
                }
                else
                {
                    ButtonIndex = 0;
                    Debug.Log("Yanlış butona basıldı. Oyun sıfırlandı.");
                }
            }
            else
            {
                ButtonIndex = 0;
                Debug.Log("Yanlış butona basıldı. Oyun sıfırlandı.");
            }
        }
        else
        {
            // Yanlış sırayla bir butona basıldıysa oyunu sıfırla
            ButtonIndex = 0;
            Debug.Log("Yanlış butona basıldı. Oyun sıfırlandı.");
        }
    }
}