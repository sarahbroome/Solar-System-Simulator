using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject planetGeneratorUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
        
    }

    public void Resume(){
        planetGeneratorUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        planetGeneratorUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }



    public void SpawnPlanet(){
        planetGeneratorUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Planet has been spawned");
        /*

        INSERT CODE THAT LAUNCHES PLANET

        */
    }

    public void QuitGame(){
        Debug.Log("Yeet");
        Application.Quit();
    }

    // public void RestartLevel(){
    //     pauseMenuUI.SetActive(false);
    //     Time.timeScale = 1f;
    //     GameIsPaused = false;
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }
}