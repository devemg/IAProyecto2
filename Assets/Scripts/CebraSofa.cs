using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CebraSofa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void setNE() {
        gameObject.transform.Translate(-0.7f, 0, 1.3f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    public void setNO(){
        gameObject.transform.Translate(0.8f, 0, 1.3f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    public void setSE(){
        gameObject.transform.Translate(-0.7f, 0, -1.3f);
    }

    public void setSO(){
        gameObject.transform.Translate(0.8f, 0, -1.3f);
    }

    public void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
