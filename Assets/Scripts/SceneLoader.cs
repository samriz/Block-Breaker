using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //get current build index of scene we're currently in
        SceneManager.LoadScene(currentSceneIndex + 1); //load next scene
    }

    public void loadStartScene()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void playAgain(){
        SceneManager.LoadScene("Level 1");
    }

    public void quitGame(){Application.Quit();} //quit game in standalone build
}