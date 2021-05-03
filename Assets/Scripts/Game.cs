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
        Debug.Log(Game.Instance.Espacios.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool ExistePiso(Piso piso) {
        foreach(Espacio espacio in Game.Instance.Espacios){
            if(espacio.piso.Equals(piso)){
                return true;
            }
        }
        return false;
    }

    public void EliminarEspacio(Piso piso){
         foreach(Espacio espacio in Game.Instance.Espacios){
            if(espacio.piso.Equals(piso)){
                Game.Instance.Espacios.Remove(espacio);
                break;
            }
        }
    }

    public void EditarEspacio(Piso piso, Espacio eEspacio){
         foreach(Espacio espacio in Game.Instance.Espacios){
            if(espacio.piso.Equals(piso)){
                espacio = eEspacio;
                break;
            }
        }
    }

}
