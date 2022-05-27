using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGameScene : MonoBehaviour
{
    public GameObject inGameScreen, pauseScreen;
   
    void Start()
    {
        
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        inGameScreen.SetActive(false);

        pauseScreen.SetActive(true);
    }

    void Update()
    {
        
    }

    public void PlayButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        inGameScreen.SetActive(true);
    }

    public void RePlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
