using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public static int brickCount;

    void Start()
    {
      
    }



    public void LevelLoad(string name)
    {
        SceneManager.LoadScene(name);
    }


    public void ExitGame()
    {
        print("tried to exit");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
    
}
