using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCebra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GetPlanta().setSE();
        GetMesa().center();
        GetSilla().setSO();
        GetLampara().setNO();
        GetSofa().setNE();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public CebraMesa GetMesa() {
        GameObject mesa = GameObject.Find("Cebra_mesa");
        return (CebraMesa) mesa.GetComponent(typeof(CebraMesa));
    }

    public CebraSilla GetSilla() {
        GameObject silla = GameObject.Find("Cebra_silla");
        return (CebraSilla) silla.GetComponent(typeof(CebraSilla));
    }

    public CebraLampara GetLampara(){
        GameObject lamp = GameObject.Find("Cebra_lampara");
        return (CebraLampara) lamp.GetComponent(typeof(CebraLampara));
    }

    public CebraSofa GetSofa(){
        GameObject sillon = GameObject.Find("Cebra_sillon");
        return (CebraSofa) sillon.GetComponent(typeof(CebraSofa));
        
    }

    public CebraPlanta GetPlanta() {
        GameObject planta = GameObject.Find("Cebra_planta");
        return (CebraPlanta) planta.GetComponent(typeof(CebraPlanta));
    }
}
