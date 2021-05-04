using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditarEspacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
    }

    void OnDisable()
    {
        gameObject.transform.Find("piso1").gameObject.SetActive(false);
        gameObject.transform.Find("piso2").gameObject.SetActive(false);
        gameObject.transform.Find("piso3").gameObject.SetActive(false);
        gameObject.transform.Find("piso4").gameObject.SetActive(false);
        gameObject.transform.Find("piso5").gameObject.SetActive(false);
        gameObject.transform.Find("piso6").gameObject.SetActive(false);
        gameObject.transform.Find("EditarUnEspacio").gameObject.SetActive(false);
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

    public void editarPiso1(){
        gameObject.transform.Find("EditarUnEspacio").gameObject.SetActive(true);
        Game.Instance.EspacioEditable =  Game.Instance.getEspacio(Piso.PISO1);

    }

    public void editarPiso2(){
        gameObject.transform.Find("EditarUnEspacio").gameObject.SetActive(true);
        Game.Instance.EspacioEditable =  Game.Instance.getEspacio(Piso.PISO2);
    }

    public void editarPiso3(){
        gameObject.transform.Find("EditarUnEspacio").gameObject.SetActive(true);
        Game.Instance.EspacioEditable =  Game.Instance.getEspacio(Piso.PISO3);

    }

    public void editarPiso4(){
        gameObject.transform.Find("EditarUnEspacio").gameObject.SetActive(true);
        Game.Instance.EspacioEditable =  Game.Instance.getEspacio(Piso.PISO4);
    }

    public void editarPiso5(){
        gameObject.transform.Find("EditarUnEspacio").gameObject.SetActive(true);
        Game.Instance.EspacioEditable =  Game.Instance.getEspacio(Piso.PISO5);
    }

    public void editarPiso6(){
        gameObject.transform.Find("EditarUnEspacio").gameObject.SetActive(true);
        Game.Instance.EspacioEditable =  Game.Instance.getEspacio(Piso.PISO6);
    }
}
