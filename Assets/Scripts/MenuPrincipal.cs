using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void salir(){
        Game.Instance.genLog();
        Application.Quit();
    }

    public void GoToVR(){
        SceneManager.LoadScene("Spaces");
        Game.Instance.addLogAction("Se visualizaron los espacios.");
    }

    public void BackMenu(){
        SceneManager.LoadScene("Mainmenu");
    }
}
