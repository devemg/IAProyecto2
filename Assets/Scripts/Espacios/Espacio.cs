using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public enum EspacioPos {
    NE,
    NO,
    SE,
    SO,
    CENTER,
    NULL
}

public enum Piso {
    CEBRA,
    JIRAFA,
     NULL
}
public class Espacio
{
    public EspacioPos posMesa { get; set; }
    public EspacioPos posSilla { get; set; } 
    public EspacioPos posPlanta { get; set; }
    public EspacioPos posLampara { get; set; }
    public EspacioPos posSofa { get; set; }

    public Piso piso { get; set; }
    int error = 0;
    public Espacio() {
        piso = Piso.NULL;
        posSofa  = EspacioPos.NULL; 
        posLampara  = EspacioPos.NULL; 
        posPlanta  = EspacioPos.NULL; 
        posSilla  = EspacioPos.NULL; 
        posMesa  = EspacioPos.NULL; 
    }

    public bool isNotNull(){
        return 
        posLampara != EspacioPos.NULL &&
        posPlanta != EspacioPos.NULL &&
        posMesa != EspacioPos.NULL &&
        posSilla != EspacioPos.NULL &&
        posSofa != EspacioPos.NULL && 
        piso != Piso.NULL;
    }

    public bool isNotRepeat(){
        return error == 0;
    }

    public void showPos(){
       Debug.Log("PISO: "+piso.ToString());
       Debug.Log("mesa: "+posMesa.ToString());
       Debug.Log("silla"+posSilla.ToString());
       Debug.Log("sofa"+posSofa.ToString());
       Debug.Log("planta"+posPlanta.ToString());
       Debug.Log("lampara"+posLampara.ToString());
    }

}
