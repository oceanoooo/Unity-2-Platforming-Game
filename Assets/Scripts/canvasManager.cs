using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    
    public GameObject FadePanel;
    
    private void Start()  
        
        Fadepanel.Setactivate(false);   
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        //SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex+1)%SceneManager.sceneCountInBuildSettings);
    }
}
    Fadepanel.Setactivate(true)
    for (int i = 0; i < 100; i++)


SceneManager.LoadScene(SeceneToLoad);