using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SofaSO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setSO();
    }

    void setSO(){
        gameObject.transform.Translate(0.8f, 0, -1.3f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
