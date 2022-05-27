using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryBoardManagerScripts : MonoBehaviour
{
    public GameObject GoBackMainMenu;

    public void GoBackButton()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
