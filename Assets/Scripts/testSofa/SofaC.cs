using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SofaC : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        center();
    }

    void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
