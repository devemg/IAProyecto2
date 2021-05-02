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
    void setNO(){
        gameObject.transform.Translate(-1.5f, 0, 1.2f);
        gameObject.transform.Rotate(0, 90f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
