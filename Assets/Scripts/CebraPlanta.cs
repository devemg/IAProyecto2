using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CebraPlanta : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        center();   
    }

    void setNE() {
        gameObject.transform.Translate(-2.6f, 0, 2f);
    }

    void setNO(){
        gameObject.transform.Translate(0f, 0, 2f);
    }

    void setSE(){
        gameObject.transform.Translate(-2.6f, 0, -0.6f);
    }

    void setSO(){
        gameObject.transform.Translate(-0.2f, 0, -0.6f);
    }

    void center(){
        gameObject.transform.Translate(-1.3f, 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
