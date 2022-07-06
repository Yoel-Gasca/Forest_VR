using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{

    //Menu variables
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;
    private bool gamePause = false;
    [SerializeField]new private GameObject audio;

    //Pause function with one key
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(gamePause){
                Continue();
            }else{
                Pause();
            }
        }
    }
    //Pause function
    public void Pause(){
        gamePause = true;
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);
        audio.SetActive(false);
   }

    //Continue function
   public void Continue(){
        gamePause = false;
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
        audio.SetActive(true);
   }

    //Scene change
   public void Entorno(){
        SceneManager.LoadScene("Enviroment");
   }

    //Quit the app
   public void Quit(){
        Application.Quit();
   }

}
