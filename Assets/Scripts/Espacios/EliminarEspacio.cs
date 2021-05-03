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

    public void EliminarPiso1(){
        Game.Instance.EliminarEspacio(Piso.PISO1);
        gameObject.transform.Find("piso1").gameObject.SetActive(false);
        MessageBox.Instance.setMessage("Piso eliminado").Show();
        Game.Instance.addLogAction("Piso eliminado");
    }

    public void EliminarPiso2(){
        Game.Instance.EliminarEspacio(Piso.PISO2);
        gameObject.transform.Find("piso2").gameObject.SetActive(false);
        MessageBox.Instance.setMessage("Piso eliminado").Show();
        Game.Instance.addLogAction("Piso eliminado");
    }

    public void EliminarPiso3(){
        Game.Instance.EliminarEspacio(Piso.PISO3);
        gameObject.transform.Find("piso3").gameObject.SetActive(false);
        MessageBox.Instance.setMessage("Piso eliminado").Show();
        Game.Instance.addLogAction("Piso eliminado");
    }

    public void EliminarPiso4(){
        Game.Instance.EliminarEspacio(Piso.PISO4);
        gameObject.transform.Find("piso4").gameObject.SetActive(false);
        MessageBox.Instance.setMessage("Piso eliminado").Show();
        Game.Instance.addLogAction("Piso eliminado");
    }

    public void EliminarPiso5(){
        Game.Instance.EliminarEspacio(Piso.PISO5);
        gameObject.transform.Find("piso5").gameObject.SetActive(false);
        MessageBox.Instance.setMessage("Piso eliminado").Show();
        Game.Instance.addLogAction("Piso eliminado");
    }

    public void EliminarPiso6(){
        Game.Instance.EliminarEspacio(Piso.PISO6);
        gameObject.transform.Find("piso6").gameObject.SetActive(false);
        MessageBox.Instance.setMessage("Piso eliminado").Show();
        Game.Instance.addLogAction("Piso eliminado");
    }

    void OnDisable()
    {
        gameObject.transform.Find("piso1").gameObject.SetActive(false);
        gameObject.transform.Find("piso2").gameObject.SetActive(false);
        gameObject.transform.Find("piso3").gameObject.SetActive(false);
        gameObject.transform.Find("piso4").gameObject.SetActive(false);
        gameObject.transform.Find("piso5").gameObject.SetActive(false);
        gameObject.transform.Find("piso6").gameObject.SetActive(false);
    }

    void OnEnable()
    {
        if(Game.Instance.ExistePiso(Piso.PISO1)){
            gameObject.transform.Find("piso1").gameObject.SetActive(true);
        }
        if(Game.Instance.ExistePiso(Piso.PISO2)){
            gameObject.transform.Find("piso2").gameObject.SetActive(true);
        }
        if(Game.Instance.ExistePiso(Piso.PISO3)){
            gameObject.transform.Find("piso3").gameObject.SetActive(true);
        }
        if(Game.Instance.ExistePiso(Piso.PISO4)){
            gameObject.transform.Find("piso4").gameObject.SetActive(true);
        }
        if(Game.Instance.ExistePiso(Piso.PISO5)){
            gameObject.transform.Find("piso5").gameObject.SetActive(true);
        }
        if(Game.Instance.ExistePiso(Piso.PISO6)){
            gameObject.transform.Find("piso6").gameObject.SetActive(true);
        }
    }
}
