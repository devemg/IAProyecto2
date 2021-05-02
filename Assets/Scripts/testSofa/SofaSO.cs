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
       gameObject.transform.Translate(1.2f, 0, 1.5f);
        gameObject.transform.Rotate(0, -90f, 0);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
