using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CebraMesa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setNO();
    }
    
    void setNE() {
        gameObject.transform.Translate(1.2f, 0,-1.026f);        
    }

    void setNO(){
        gameObject.transform.Translate(0f, 0, 0f);
    }

    void setSE(){
        gameObject.transform.Translate(1.219f, 0, 1.244f);
    }

    void setSO(){
        gameObject.transform.Translate(-6f, 0, 0f);
    }

    void center(){
        gameObject.transform.Translate(0, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}