using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planta : MonoBehaviour
{

    void center(){
        gameObject.transform.Translate(0, 0, 0);
    }

    void setNE() {
        gameObject.transform.Translate(-1.3f, 0, 1.3f);
    }

    void setNO(){
        gameObject.transform.Translate(1.3f, 0, 1.3f);
    }

    void setSE(){
        gameObject.transform.Translate(-1.3f, 0, -1.3f);
    }

    void setSO(){
        gameObject.transform.Translate(1.3f, 0, -1.3f);
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

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnEnable()
    {
    }
}
