using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void button1()
    {
        PlayerPrefs.SetInt("count", 1);
    }
    public void button2()
    {
        if (PlayerPrefs.GetInt("count")==1)
        {
            PlayerPrefs.SetInt("count", 2);

        }
        else
        {
            PlayerPrefs.SetInt("count", 0);
        }

    }
    public void button3()
    {
        if (PlayerPrefs.GetInt("count") == 2)
        {
            PlayerPrefs.SetInt("count", 3);
        }
        else
        {
            PlayerPrefs.SetInt("count", 0);
        }

    }
    public void button4()
    {
        if (PlayerPrefs.GetInt("count") == 3)
        {
            PlayerPrefs.SetInt("count", 4);
            door.SetActive(false);
            Debug.Log("wel done");
        }
        else
        {
            PlayerPrefs.SetInt("count", 0);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Buton2")
        {
            button1();
            Debug.Log("1");
        }
        else if (collision.gameObject.name == "Buton4")
        {
            button2();
            Debug.Log("1");

        }
        else if (collision.gameObject.name == "Buton1")
        {
            button3();
               Debug.Log("1");

        }
        else if (collision.gameObject.name == "Buton3")
        {
            button4();
            Debug.Log("1");

        }
    }
}
