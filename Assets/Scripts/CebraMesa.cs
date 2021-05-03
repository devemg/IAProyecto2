using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CebraMesa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    public void setNE() {
        gameObject.transform.Translate(-1.3f, 0, 1.3f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    public void setNO(){
        gameObject.transform.Translate(1.3f, 0, 1.3f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    public void setSE(){
        gameObject.transform.Translate(-1.3f, 0, -1.3f);
    }

    public void setSO(){
        gameObject.transform.Translate(1.3f, 0, -1.3f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
