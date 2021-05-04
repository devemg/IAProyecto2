using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silla : MonoBehaviour
{

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
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setPosition(EspacioPos position) {
        switch(position) {
            case EspacioPos.NE:
                this.setNE();
            break;
            case EspacioPos.NO:
                this.setNO();
            break;
            case EspacioPos.SE:
                this.setSE();
            break;
            case EspacioPos.SO:
                this.setSO();
            break;
            case EspacioPos.CENTER:
                this.center();
            break;
        }
    }
}
