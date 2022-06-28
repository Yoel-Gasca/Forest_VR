using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 

    public void juego()
    {
        SceneManager.LoadScene("Bosque");
    }

    public void quit(){
        Application.Quit();
    }
}
