using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditarEspacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Game.Instance.ExistePiso(Piso.CEBRA)){
            GameObject.Find("cebra").SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
