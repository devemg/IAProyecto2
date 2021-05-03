using System.Collections;
using System.Collections.Generic;

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
    EspacioPos posMesa = EspacioPos.NULL; 
    EspacioPos posSilla = EspacioPos.NULL; 
    EspacioPos posPlanta = EspacioPos.NULL; 
    EspacioPos posLampara = EspacioPos.NULL; 
    EspacioPos posSofa = EspacioPos.NULL; 

    Piso piso = Piso.NULL;

    public void setPiso(Piso pos){
        piso = pos;
    }

    public void setSofa(EspacioPos indice){
        posSofa = indice;
    }

    public void setLampara(EspacioPos indice){
        posLampara = indice;
    }

    public void setPlanta(EspacioPos indice){
        posPlanta = indice;
    }

    public void setMesa(EspacioPos indice){
        posMesa = indice;
    }

    public void setSilla(EspacioPos indice){
        posSilla = indice;
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
}
