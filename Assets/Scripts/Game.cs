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
        AddEspacio(Piso.PISO1);
        AddEspacio(Piso.PISO2);
        AddEspacio(Piso.PISO3);
        AddEspacio(Piso.PISO4);
        AddEspacio(Piso.PISO5);
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

    public void AddEspacio(Piso piso){
        Espacio nespacio = new Espacio();
        nespacio.piso = piso; 
        nespacio.posLampara = EspacioPos.NO;
        nespacio.posMesa = EspacioPos.NE; 
        nespacio.posPlanta =  EspacioPos.SO;
        nespacio.posSilla = EspacioPos.SE; 
        nespacio.posSofa = EspacioPos.CENTER; 
        Game.Instance.Espacios.Add(nespacio);
        Debug.Log(Espacios.Count);
    }
    public void genLog(string path){
        //StreamReader Leer;
        //StreamWriter Escribir;
    }

}
