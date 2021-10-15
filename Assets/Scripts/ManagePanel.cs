using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePanel : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject F;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (F.gameObject == null)
        {
            audioSource.Stop();
            StartCoroutine(wait());
            

            

        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);

        p1.SetActive(true);
        p2.SetActive(false);
    }
    // Start is called before the first frame update
    

    
}
