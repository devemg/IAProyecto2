using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditarUnEspacio : MonoBehaviour
{
    Espacio espacioActual;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable() {
        espacioActual = Game.Instance.EspacioEditable;
        if(espacioActual == null){
            espacioActual = new Espacio();
        }
        Debug.Log(espacioActual.piso);
    }

    public void editar() {
        
    }

     public void setPiso(int indice){
        espacioActual.piso = GetPiso(indice);
    }

    public void setSofa(int indice){
        espacioActual.posSofa = GetPos(indice);
    }

    public void setLampara(int indice){
        espacioActual.posLampara = GetPos(indice);
    }

    public void setPlanta(int indice){
        espacioActual.posPlanta = GetPos(indice);
    }

    public void setMesa(int indice){
        espacioActual.posMesa = GetPos(indice);
    }

    public void setSilla(int indice){
        espacioActual.posSilla = GetPos(indice);
    }

    EspacioPos GetPos(int indice) {
        switch(indice) {
            case 1: return EspacioPos.CENTER;
            case 2: return EspacioPos.NE;
            case 3: return EspacioPos.NO;
            case 4: return EspacioPos.SE;
            case 5: return EspacioPos.SO;
            default: return EspacioPos.NULL;
        }
    }

    Piso GetPiso(int indice){
        Debug.Log(indice);
        switch(indice) {
            case 1: return Piso.PISO1;
            case 2: return Piso.PISO2;
            case 3: return Piso.PISO3;
            case 4: return Piso.PISO4;
            case 5: return Piso.PISO5;
            case 6: return Piso.PISO6;
            default: return Piso.NULL;
        }
    }
}
