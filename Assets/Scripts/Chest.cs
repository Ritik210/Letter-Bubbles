using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public Animator anim;
    public GameObject Panel;
    public GameObject Cross;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "B" && Cross.active == false)
        {
            Debug.Log("Triggered");
            anim.SetBool("Play", true);
            Panel.SetActive(true);
        }

        if(collision.gameObject.tag == "A" || collision.gameObject.tag == "E" || collision.gameObject.tag == "C" || collision.gameObject.tag == "D" || collision.gameObject.tag == "F")
        {
            Cross.SetActive(true);
            StartCoroutine(stop());

        }

    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(3);
        Cross.SetActive(false);
    }
}
