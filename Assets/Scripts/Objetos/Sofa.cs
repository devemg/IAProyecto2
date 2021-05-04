using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sofa : MonoBehaviour
{
    void setNE() {
        gameObject.transform.Translate(-0.7f, 0, 1.3f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    void setNO(){
        gameObject.transform.Translate(0.8f, 0, 1.3f);
        gameObject.transform.Rotate(0, 180f, 0);
    }

    void setSE(){
        gameObject.transform.Translate(-0.7f, 0, -1.3f);
    }

    void setSO(){
        gameObject.transform.Translate(0.8f, 0, -1.3f);
    }

    void center(){
        gameObject.transform.Translate(0, 0, 0);
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
