using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    //Changing menu scene to game
    public void juego()
    {
        SceneManager.LoadScene("Bosque");
    }

    //Quit the app
    public void quit(){
        Application.Quit();
    }
}
