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

    void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    void setNE() {
        gameObject.transform.Translate(-1.3f, 0, 1.3f);
    }

    void setNO(){
        gameObject.transform.Translate(1.3f, 0, 1.3f);
    }

    void setSE(){
        gameObject.transform.Translate(-1.3f, 0, -1.3f);
    }

    void setSO(){
        gameObject.transform.Translate(1.3f, 0, -1.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}