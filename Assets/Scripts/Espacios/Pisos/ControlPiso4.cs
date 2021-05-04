using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPiso4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
        if(Game.Instance.ExistePiso(Piso.PISO4)){
            Espacio espacio = Game.Instance.getEspacio(Piso.PISO4);
            // posicionando objetos
            GetPlanta().setPosition(espacio.posPlanta);
            GetSofa().setPosition(espacio.posSofa);
            GetLampara().setPosition(espacio.posLampara);
            GetMesa().setPosition(espacio.posMesa);
            GetSilla().setPosition(espacio.posSilla);
        }else {
            gameObject.SetActive(false);
            Debug.LogWarning("NO EXISTE PISO 4");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Mesa GetMesa() {
        GameObject mesa = GameObject.Find("mesa4");
        return (Mesa) mesa.GetComponent(typeof(Mesa));
    }

    public Silla GetSilla() {
        GameObject silla = GameObject.Find("silla4");
        return (Silla) silla.GetComponent(typeof(Silla));
    }

    public Lampara GetLampara(){
        GameObject lamp = GameObject.Find("lampara4");
        return (Lampara) lamp.GetComponent(typeof(Lampara));
    }

    public Sofa GetSofa(){
        GameObject sillon = GameObject.Find("sofa4");
        return (Sofa) sillon.GetComponent(typeof(Sofa));
        
    }

    public Planta GetPlanta() {
        GameObject planta = GameObject.Find("planta4");
        return (Planta) planta.GetComponent(typeof(Planta));
    }
}
