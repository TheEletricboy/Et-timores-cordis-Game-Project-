using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_MouselUnlock : MonoBehaviour
{
    // had to be created as a plan B in case issues were found when locking the mouse in scenes
    private void Awake()
    {
        Unlock();
        Debug.Log("mouse is unlocked?");
    }
    

    private void Unlock()
    {

        Cursor.lockState = CursorLockMode.None;
    }
}
