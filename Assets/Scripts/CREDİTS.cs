using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CREDİTS : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > 16f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
