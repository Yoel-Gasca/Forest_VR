using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;
    private bool gamePause = false;
    [SerializeField] private GameObject audio;
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(gamePause){
                Continue();
            }else{
                Pause();
            }
        }
    }
    public void Pause(){
        gamePause = true;
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);
        audio.SetActive(false);
   }

   public void Continue(){
        gamePause = false;
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
        audio.SetActive(true);
   }

   public void Quit(){
        Application.Quit();
   }

}
