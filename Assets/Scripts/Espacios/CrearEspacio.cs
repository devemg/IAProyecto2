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
            if(espacioActual.isNotRepeat()) {
            Debug.Log("creando...");
                if(Game.Instance.Espacios.Count < 6) {
                    if(!Game.Instance.ExistePiso(espacioActual.piso)){
                        Game.Instance.Espacios.Add(espacioActual);
                        MessageBox.Instance.setMessage("¡Espacio creado!").Show(); 
                        Debug.Log(Game.Instance.Espacios.Count); 
                        espacioActual = CopiarEspacio();
                        Game.Instance.addLogAction("Se ha creado un espacio");
                    }else{
                        MessageBox.Instance.setError("El piso ya existe.").Show();
                        Game.Instance.addLogError("No se puede crear el espacio, el piso ya existe");
                    }
                }else {
                    MessageBox.Instance.setError("Ya existen 6 espacios").Show();
                    Game.Instance.addLogError("No se puede crear el espacio, ya existen 6 espacios");
                }
            }else {
                MessageBox.Instance.setError("No se pueden repetir espacios y muebles").Show();
                Game.Instance.addLogError("No se pueden repetir espacios y muebles.");
            }
        }else{  
            MessageBox.Instance.setError("Los elementos no están completos.").Show();
            Game.Instance.addLogError("No se puede crear el espacio, los elementos no están completos");
        }
    }

    public void setPiso(int indice){
        //Debug.Log(indice);
        //Debug.Log(GetPiso(indice).ToString());
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
            case 1: return Piso.CEBRA;
            case 2: return Piso.JIRAFA;
            default: return Piso.NULL;
        }
    }

    public Espacio CopiarEspacio() {
        Espacio nuevoEspacio = new Espacio();
        nuevoEspacio.piso = espacioActual.piso;
        nuevoEspacio.posSofa  = espacioActual.posSofa; 
        nuevoEspacio.posLampara  = espacioActual.posLampara; 
        nuevoEspacio.posPlanta  = espacioActual.posPlanta; 
        nuevoEspacio.posSilla  = espacioActual.posSilla; 
        nuevoEspacio.posMesa  = espacioActual.posMesa; 
        return nuevoEspacio;
    }
}
