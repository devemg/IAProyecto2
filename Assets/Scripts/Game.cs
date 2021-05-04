using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public static Game Instance; 
    public ArrayList Espacios = new ArrayList();
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
        cebra.posPlanta = EspacioPos.NE;
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

}
