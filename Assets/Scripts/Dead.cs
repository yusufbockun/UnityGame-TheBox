using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    private Rigidbody2D rig2d;
    void Start()
    {
        anim= GetComponent<Animator>();
        rig2d= GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            rig2d.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("die");
        }

    }
    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
