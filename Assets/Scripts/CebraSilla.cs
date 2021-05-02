using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CebraSilla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setSO();
    }

    void setNE() {
        gameObject.transform.Translate(1.302f, 0,-1.026f);        
    }

    void setNO(){
        gameObject.transform.Translate(-0.36f, 0, -0.928f);
    }

    void setSE(){
        gameObject.transform.Translate(0f, 0, 0f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    void setSO(){
        gameObject.transform.Translate(1.327f, 0, 1.351f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
