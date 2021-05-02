using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CebraSilla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setNO();
    }
    void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    void setNE() {
         gameObject.transform.Translate(-1.2f, 0, -1.5f);
        gameObject.transform.Rotate(0, 90f, 0);
    }

    void setNO(){   
        gameObject.transform.Translate(-1.5f, 0, 1.2f);
        gameObject.transform.Rotate(0, 90f, 0);
    }

    void setSE(){
        gameObject.transform.Translate(1.5f, 0, -1.2f);
        gameObject.transform.Rotate(0, -90f, 0);
    }

    void setSO(){
       gameObject.transform.Translate(1.2f, 0, 1.5f);
        gameObject.transform.Rotate(0, -90f, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
