using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCebra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject planta = GameObject.Find("Cebra_planta");
        CebraPlanta other = (CebraPlanta) planta.GetComponent(typeof(CebraPlanta));
        other.setSE();

        GameObject sillon = GameObject.Find("Cebra_sillon");
        CebraSofa other1 = (CebraSofa) sillon.GetComponent(typeof(CebraSofa));
        other1.setNE();

        
        GetMesa().center();

        GameObject silla = GameObject.Find("Cebra_silla");
        CebraSilla other3 = (CebraSilla) silla.GetComponent(typeof(CebraSilla));
        other3.setSO();

        GameObject lamp = GameObject.Find("Cebra_lampara");
        CebraLampara other4 = (CebraLampara) lamp.GetComponent(typeof(CebraLampara));
        other4.setNO();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public CebraMesa GetMesa() {
        GameObject mesa = GameObject.Find("Cebra_mesa");
        return (CebraMesa) mesa.GetComponent(typeof(CebraMesa));
    }

}
