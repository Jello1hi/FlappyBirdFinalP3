using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float upForce;
    private bool isDead = false;
    private Animator anim;

    private Rigidbody2D rigidbody2D; 

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("Flap");
                rigidbody2D.velocity = Vector2.zero;
                rigidbody2D.AddForce(new Vector2(0, upForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        rigidbody2D.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
       
    }
}
