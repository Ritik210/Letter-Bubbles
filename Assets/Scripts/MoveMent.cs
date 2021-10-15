using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    int speed = 3;
    public Rigidbody2D rb;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.left * Time.deltaTime * speed);

        


    }

    
    private void OnMouseDown()
    {
        // audioSource.mute = !audioSource.mute;
        audioSource.Play();

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Nice");
            
            rb.gravityScale = 1.0f;
            speed = 0;
            
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);

           // Debug.Log("Destroy");
        }
    }
}
