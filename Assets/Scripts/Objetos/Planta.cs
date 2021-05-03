using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planta : MonoBehaviour
{

    public void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    public void setNE() {
        gameObject.transform.Translate(-1.3f, 0, 1.3f);
    }

    public void setNO(){
        gameObject.transform.Translate(1.3f, 0, 1.3f);
    }

    public void setSE(){
        gameObject.transform.Translate(-1.3f, 0, -1.3f);
    }

    public void setSO(){
        gameObject.transform.Translate(1.3f, 0, -1.3f);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
