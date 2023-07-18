using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {

        Application.Quit();
        Debug.Log("Quit Clicked!");
    }
    
    public void LevelOne()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void LevelThree()
    {
        SceneManager.LoadScene("Level_3");
    }

}
