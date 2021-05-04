using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCebra : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
        if(Game.Instance.ExistePiso(Piso.CEBRA)){
            Espacio espacio = Game.Instance.getEspacio(Piso.CEBRA);
            // posicionando objetos
            GetPlanta().setPosition(espacio.posPlanta);
            GetSofa().setPosition(espacio.posSofa);
            GetLampara().setPosition(espacio.posLampara);
            GetMesa().setPosition(espacio.posMesa);
            GetSilla().setPosition(espacio.posSilla);
        }
        
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
