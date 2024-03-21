using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private enum MovementState { idle, run, jump, fall };
    private Rigidbody2D rb;
    private float dirX, dirY;
    private Animator anim;
    public RuntimeAnimatorController vrAnim;
    public GameObject blackScreen;
    public AudioSource run, jump;
    private bool isRunning, isJumping;

    // Start is called before the first frame update
    void Start()
    {
        if (blackScreen != null) blackScreen.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isRunning = false;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = rb.velocity.x;
        dirY = rb.velocity.y;
        update_animation();
    }

    private void update_animation()
    {
        MovementState state;
        if (dirX > 0.5f || dirX < -0.5f) //run
        {
            state = MovementState.run;
            if (!isRunning)
            {
                run.Play();
                isRunning = true;
            }
        }
        else
        {
            state = MovementState.idle;

            if (isRunning)
            {
                run.Stop();
                isRunning = false;
            }
        }
        if (dirY > 0.5f) //jump
        {
            state = MovementState.jump;
            if (!isJumping)
            {
                if (!jump.isPlaying) // Eðer zýplama sesi çalmýyorsa çal
                {
                    jump.Play();
                    isJumping = true;
                }
            }
            
        }
        else if (dirY < -0.2f)
        {
            isJumping = false;

            state = MovementState.fall;
        }

        anim.SetInteger("state", (int)state);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("VR"))
        {
            anim.runtimeAnimatorController = vrAnim;
            if (blackScreen != null) blackScreen.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
