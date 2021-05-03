using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public static Game Instance; 
    public ArrayList Espacios = new ArrayList();
    List<string> log = new List<string>();

    private void Awake(){
        if(Instance == null){
            DontDestroyOnLoad(gameObject);
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creando Global...");
        Espacio cebra = new Espacio();
        cebra.piso = Piso.CEBRA; 

        cebra.posMesa = EspacioPos.NO;
        cebra.posPlanta = EspacioPos.SO;
        cebra.posLampara = EspacioPos.NE;
        cebra.posSilla = EspacioPos.CENTER;
        cebra.posSofa = EspacioPos.SE;

        Espacios.Add(cebra);
        Debug.Log(Espacios.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool ExistePiso(Piso piso) {
        foreach(Espacio espacio in Espacios){
            if(espacio.piso.Equals(piso)){
                return true;
            }
        }
        return false;
    }

    public void EliminarEspacio(Piso piso){
         foreach(Espacio espacio in Espacios){
            if(espacio.piso.Equals(piso)){
                Espacios.Remove(espacio);
                break;
            }
        }
    }

    public void EditarEspacio(Piso piso, Espacio eEspacio){
        int index = 0; 
        bool existe = false;
        foreach(Espacio espacio in Espacios){
            if(espacio.piso.Equals(piso)){
                existe = true;
                break;
            }
            index++;
        }
        //verificar
        if(existe){
            Espacios[index] = eEspacio;
        }
    }

    public Espacio getEspacio(Piso piso) {
        foreach(Espacio espacio in Espacios){
            if(espacio.piso.Equals(piso)){
                return espacio;
            }
        }
        return null;
    }
    
    public void addLogAction(string content){
        log.Add("[ACCION] "+content);
    }

    public void addLogError(string content){
        log.Add("[ERROR] "+content);
    }

    public void genLog(string path){
        //StreamReader Leer;
        //StreamWriter Escribir;
    }

}
