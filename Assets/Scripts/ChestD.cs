using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestD : MonoBehaviour
{
    public Animator anim;
    public GameObject Panel;

    public GameObject cross2;
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
        if (collision.gameObject.tag == "D" && cross2.active == false)
        {
            Debug.Log("Triggered");
            anim.SetBool("Play", true);
            Panel.SetActive(true);


        }

        if (collision.gameObject.tag == "A" || collision.gameObject.tag == "E" || collision.gameObject.tag == "C" || collision.gameObject.tag == "B" || collision.gameObject.tag == "F")
        {
            cross2.SetActive(true);
            StartCoroutine(stop());

        }
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(3);
        cross2.SetActive(false);
    }
}
