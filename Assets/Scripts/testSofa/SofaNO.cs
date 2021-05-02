using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SofaNO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setNO();
    }

    void setNE() {
        gameObject.transform.Translate(0.785f, 0, -1.175f);
    }

    void setNO(){
        gameObject.transform.Translate(-0.72f, 0, -1.175f);
    }

    void setSE(){
        gameObject.transform.Translate(1.7f, 0, 2.5f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    void setSO(){
        gameObject.transform.Translate(0.5f, 0, -0.6f);
        gameObject.transform.Rotate(0, 0f, 0);
    }

    void center(){
        gameObject.transform.Translate(-0.2f, 0, 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
