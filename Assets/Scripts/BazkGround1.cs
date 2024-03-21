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
            // �lk objeyi aktif hale getir
            etkilesimObjeleri[suankiObjeIndex].SetActive(true);

            // Di�er objeleri pasif hale getir
            for (int i = 1; i < etkilesimObjeleri.Length; i++)
            {
                if (etkilesimObjeleri[i] != null)
                {
                    etkilesimObjeleri[i].SetActive(false);
                }
                else
                {
                    Debug.LogError("Etkile�im objesi ba�l� de�il veya null.");
                }
            }
        }
        else
        {
            Debug.LogError("Etkile�im objeleri bo� veya null.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
    {
            // �u anki objeyi pasif hale getir
            etkilesimObjeleri[suankiObjeIndex].SetActive(false);

            // Bir sonraki objeyi aktif hale getir
            suankiObjeIndex++;
            if (suankiObjeIndex < etkilesimObjeleri.Length)
            {
                etkilesimObjeleri[suankiObjeIndex].SetActive(true);
            }
            else
            {
                Debug.Log("T�m etkile�im objeleri aktif hale getirildi.");
            }
        }
    }

}
