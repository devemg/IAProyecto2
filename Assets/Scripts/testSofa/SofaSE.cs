using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SofaSE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setSE();
    }

    void setSE(){
        gameObject.transform.Translate(-1.3f, 0, -1.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
