using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void levelLoad(string name)
    {
        SceneManager.LoadScene(name);
    }


    public void ExitGame()
    {
        print("tried to exit");
        Application.Quit();
    }
}
