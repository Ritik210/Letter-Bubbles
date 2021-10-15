using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadS1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadS2()
    {
        SceneManager.LoadScene(2);
    }

    
    public void LoadS3()
    {
       
        SceneManager.LoadScene(3);
       
    }

}
