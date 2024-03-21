using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazkGround : MonoBehaviour
{
    public  GameObject[] etkilesimObjeleri;
    private int suankiObjeIndex = 0;

    void Start()
    {
        suankiObjeIndex = 0;
        if (etkilesimObjeleri != null && etkilesimObjeleri.Length > 0)
        {
            // Ýlk objeyi aktif hale getir
            etkilesimObjeleri[suankiObjeIndex].SetActive(true);

            // Diðer objeleri pasif hale getir
            for (int i = 1; i < etkilesimObjeleri.Length; i++)
            {
                if (etkilesimObjeleri[i] != null)
                {
                    etkilesimObjeleri[i].SetActive(false);
                }
                else
                {
                    Debug.LogError("Etkileþim objesi baðlý deðil veya null.");
                }
            }
        }
        else
        {
            Debug.LogError("Etkileþim objeleri boþ veya null.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
    {
            // Þu anki objeyi pasif hale getir
            etkilesimObjeleri[suankiObjeIndex].SetActive(false);

            // Bir sonraki objeyi aktif hale getir
            suankiObjeIndex++;
            if (suankiObjeIndex < etkilesimObjeleri.Length)
            {
                etkilesimObjeleri[suankiObjeIndex].SetActive(true);
            }
            else
            {
                Debug.Log("Tüm etkileþim objeleri aktif hale getirildi.");
            }
        }
    }

}
