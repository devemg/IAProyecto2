using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditarEspacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnDisable()
    {
    }

    void OnEnable()
    {
       if(Game.Instance.ExistePiso(Piso.CEBRA)){
           Debug.Log("PISO CEBRA");
          /* GameObject mesa = GameObject.Find("cebra");
           mesa.SetActive(true);*/
        }
    }
}
