using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditarUnEspacio : MonoBehaviour
{
    Espacio espacioActual = new Espacio();
    [SerializeField] Text Desc;
    // Start is called before the first frame update
    void Start()
    {
        initial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable() {
        initial();
    }

    void initial(){
        Espacio aEspacio = Game.Instance.EspacioEditable;
        string str_espacio = "Piso: "+aEspacio.piso+
        "\nSofá: "+aEspacio.posSofa+
        "\nLampara: "+aEspacio.posLampara+
        "\nPlanta: "+aEspacio.posPlanta+
        "\nMesa: "+aEspacio.posMesa+
        "\nSilla: "+aEspacio.posSilla;
        Desc.text = str_espacio;
    }

    public void editar() {
        if(espacioActual.isNotNull()){
            if(espacioActual.isNotRepeat()) {
                if(espacioActual.piso == Game.Instance.EspacioEditable.piso) {
                    // editar espacio 
                    Game.Instance.EditarEspacio(espacioActual.piso,espacioActual);
                    MessageBox.Instance.setMessage("¡Espacio editado!").Show(); 
                    Game.Instance.addLogAction("Se ha editado un espacio");
                }else {
                    if(!Game.Instance.ExistePiso(espacioActual.piso)){
                        // editar espacio 
                        Game.Instance.EliminarEspacio(Game.Instance.EspacioEditable.piso);
                        Game.Instance.Espacios.Add(espacioActual);
                        MessageBox.Instance.setMessage("¡Espacio editado!").Show(); 
                        Game.Instance.addLogAction("Se ha editado un espacio");
                    }else {
                        MessageBox.Instance.setError("El piso ya existe").Show();
                        Game.Instance.addLogError("El piso ya existe.");
                    }
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
