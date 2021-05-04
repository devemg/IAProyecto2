using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPiso6 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
        if(Game.Instance.ExistePiso(Piso.PISO6)){
            Espacio espacio = Game.Instance.getEspacio(Piso.PISO6);
            // posicionando objetos
            GetPlanta().setPosition(espacio.posPlanta);
            GetSofa().setPosition(espacio.posSofa);
            GetLampara().setPosition(espacio.posLampara);
            GetMesa().setPosition(espacio.posMesa);
            GetSilla().setPosition(espacio.posSilla);
        }else {
            gameObject.SetActive(false);
            Debug.LogWarning("NO EXISTE PISO 6");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Mesa GetMesa() {
        GameObject mesa = GameObject.Find("mesa6");
        return (Mesa) mesa.GetComponent(typeof(Mesa));
    }

    public Silla GetSilla() {
        GameObject silla = GameObject.Find("silla6");
        return (Silla) silla.GetComponent(typeof(Silla));
    }

    public Lampara GetLampara(){
        GameObject lamp = GameObject.Find("lampara6");
        return (Lampara) lamp.GetComponent(typeof(Lampara));
    }

    public Sofa GetSofa(){
        GameObject sillon = GameObject.Find("sofa6");
        return (Sofa) sillon.GetComponent(typeof(Sofa));
        
    }

    public Planta GetPlanta() {
        GameObject planta = GameObject.Find("planta6");
        return (Planta) planta.GetComponent(typeof(Planta));
    }
}
