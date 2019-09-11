
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelend : MonoBehaviour
{
    private void Start()
    {
        
    }


    public void OnTriggerEnter(Collider other) //entering collider
    {
        if (other.CompareTag("Player")) //must have the player tag
        {

            Time.timeScale = 1f; //resets the time scale to minimize timing bugs
            Cursor.lockState = CursorLockMode.None; //unlocks cursor
            SceneManager.LoadScene("Levels"); //loads levels scene



        }

    }
}
