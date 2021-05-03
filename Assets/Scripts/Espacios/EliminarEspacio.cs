using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarEspacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EliminarPisoCebra(){
        Game.Instance.EliminarEspacio(Piso.CEBRA);
         gameObject.transform.Find("cebra").gameObject.SetActive(false);
         MessageBox.Instance.setMessage("Piso eliminado").Show();
    }

    void OnEnable()
    {
        if(Game.Instance.ExistePiso(Piso.CEBRA)){
            Debug.Log("EXISTE CEBRA");
            gameObject.transform.Find("cebra").gameObject.SetActive(true);
        }

       /* Transform result;
        result = gameObject.transform.Find("cebra");
            if(result) {
                result.gameObject.SetActive(true);
        }*/
    }
}
