using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusObjects : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;

    

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            
            if (gameObject.tag == "A")
            {
               
                Destroy(A);
            }
           else if(gameObject.tag == "B" && A.gameObject == null)
            {
                Destroy(B);
            }

           else if (gameObject.tag == "C" && A.gameObject == null && B.gameObject == null)
            {
                Destroy(C);
            }
           else if (gameObject.tag == "D" && A.gameObject == null && B.gameObject == null && C.gameObject == null)
            {
                Destroy(D);
            }
           else if (gameObject.tag == "E" && A.gameObject == null && B.gameObject == null && C.gameObject == null && D.gameObject == null)
            {
                Destroy(E);
            }
           else if (gameObject.tag == "F" && A.gameObject == null && B.gameObject == null && C.gameObject == null && D.gameObject == null && E.gameObject == null)
            {
                Destroy(F);
            }
        }
    }

   
  
}
