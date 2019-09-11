using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LightingLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Levels_Lighting");

    }

    public void SoundLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Levels_Sound");

    }

    public void TheMainMenu()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Main_Menu");

    }

    public void Levels()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Levels");

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("app has quit mah dude");
    }

}
