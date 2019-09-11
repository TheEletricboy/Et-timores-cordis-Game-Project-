using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;

    // Update is called once per frame
    void Update()
    {
        //when pressing Escape or P (because i was having issues with mouse unlock in unity) pause
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            
            PauseToggle();
        }




    }


    //=================================================
    public void PauseToggle()
    {
        //easier than having if statements
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            //freezing time
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None; //unlocks cursor
            Cursor.visible = true; //makes cursor visible just to be sure
        }
        else
        {
            Time.timeScale = 1f; //resumes time
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked; //locks and hides mouse
        }
    }

   

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu"); //loads main menu

    }

}
