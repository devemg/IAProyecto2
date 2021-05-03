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
    public Mesa GetMesa() {
        GameObject mesa = GameObject.Find("mesa");
        return (Mesa) mesa.GetComponent(typeof(Mesa));
    }

    public Silla GetSilla() {
        GameObject silla = GameObject.Find("silla");
        return (Silla) silla.GetComponent(typeof(Silla));
    }

    public Lampara GetLampara(){
        GameObject lamp = GameObject.Find("lampara");
        return (Lampara) lamp.GetComponent(typeof(Lampara));
    }

    public Sofa GetSofa(){
        GameObject sillon = GameObject.Find("sofa");
        return (Sofa) sillon.GetComponent(typeof(Sofa));
        
    }

    public Planta GetPlanta() {
        GameObject planta = GameObject.Find("planta");
        return (Planta) planta.GetComponent(typeof(Planta));
    }
}
