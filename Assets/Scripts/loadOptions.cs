using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadOptions : MonoBehaviour
{
     public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
