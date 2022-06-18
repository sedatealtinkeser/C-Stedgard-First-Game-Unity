using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    bool zipla = true;
    bool sagabak = true;
    public float jumpForce;
    float horizontal;
    Vector3 scale;

    public AudioSource source;
    public AudioClip clip;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
                source.PlayOneShot(clip);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
                source.PlayOneShot(clip);
        }



        if (Input.GetKeyDown(KeyCode.Space)&& zipla==true)
    {
       rb.AddForce(new Vector2(0,jumpForce));
       zipla = false;
    }
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(horizontal * Time.deltaTime *speed,rb.velocity.y,0);

        if (horizontal>0 && sagabak==false)
        {
           cevir();
        }
        if(horizontal<0 && sagabak == true)
        {
           cevir();
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Platform")
      {
         zipla=true;
      }
    }
    
    void cevir()
    {
      sagabak = !sagabak;
      scale = gameObject.transform.localScale;
      scale.x = scale.x * -1;
      gameObject.transform.localScale = scale;
    }
}
