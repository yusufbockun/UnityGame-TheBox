using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float hareketHizi;
    public float ziplamaGucu = 10f;
    public LayerMask zeminKatmani;
    [SerializeField] private Transform feetPos;
    public float raycastDistance = 0.5f;
    public LayerMask obstacleLayer;
    bool facingRight = true ;



    public bool yerdeMi ;
    private Rigidbody2D rb;




    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Zipla();
    }

    void FixedUpdate()
    {



            HareketEt();
            if (rb.velocity.x < 0 && facingRight)
            {
                flipFace();
            }
            else if (rb.velocity.x > 0 && !facingRight)
            {
                flipFace();
            }
        

    }

    void HareketEt()
    {
        float yatayHareket = Input.GetAxisRaw("Horizontal");
        Vector2 hareket = new Vector2(yatayHareket, 0);
        rb.velocity = new Vector2(hareket.x * hareketHizi, rb.velocity.y);
    }
    void Zipla()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity=new Vector2(rb.velocity.x, ziplamaGucu);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }
    bool IsGrounded()
    {
      return Physics2D.OverlapCircle(feetPos.position, 0.2f, zeminKatmani);
    }

    void flipFace()
    {
        facingRight=!facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x*=-1;
        transform.localScale = tempLocalScale;
    }

}