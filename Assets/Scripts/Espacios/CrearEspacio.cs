using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEspacio : MonoBehaviour
{
    Espacio espacioActual;
    // Start is called before the first frame update
    void Start()
    {
        espacioActual = new Espacio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void crear(){
        
         if(espacioActual.isNotNull()){
           // if(espacioActual.isNotRepeat()) {
          //  Debug.Log("creando...");
                if(Game.Instance.Espacios.Count < 6) {
                    if(!Game.Instance.ExistePiso(espacioActual.piso)){
                        Game.Instance.Espacios.Add(espacioActual);
                        Debug.Log("Creado!");  
                    }else{
                        Debug.Log("El piso ya existe");
                    }
                }else {
                    Debug.Log("Ya hay 6 espacios");
                }
           // }else {
           //     Debug.Log("posiciones repetidas");
           // }
        }else{  
            Debug.Log("no estan todos los elementos");
         }
    }

    public void setPiso(int indice){
        //Debug.Log(indice);
        //Debug.Log(GetPiso(indice).ToString());
        espacioActual.piso = GetPiso(indice);
    }

    public void setSofa(int indice){
        espacioActual.setSofa(GetPos(indice));
    }

    public void setLampara(int indice){
        espacioActual.setLampara(GetPos(indice));
    }

    public void setPlanta(int indice){
        espacioActual.setPlanta(GetPos(indice));
    }

    public void setMesa(int indice){
        espacioActual.setMesa(GetPos(indice));
    }

    public void setSilla(int indice){
        espacioActual.setSilla(GetPos(indice));
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
        switch(indice) {
            case 1: return Piso.CEBRA;
            case 2: return Piso.JIRAFA;
            default: return Piso.NULL;
        }
    }
}
