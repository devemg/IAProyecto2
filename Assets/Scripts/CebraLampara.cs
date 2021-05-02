using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CebraLampara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setSE();
    }

    void setNE() {
        gameObject.transform.Translate(1.35f, 0,-1.26f);        
    }

    void setNO(){
        gameObject.transform.Translate(-1.26f, 0, -1.26f);
    }

    void setSE(){
        gameObject.transform.Translate(1.404f, 0, 1.38f);
    }

    void setSO(){
        gameObject.transform.Translate(-1.26f, 0, 1.402f);
    }

    void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
