using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{

    [SerializeField] private Light flashLight;
    private bool isActive;
    


    // Start is called before the first frame update
    void Start()
    {
        isActive = false; //sets its bool to false
        flashLight.enabled = false; //begins disabled
    }

    // Update is called once per frame
    void Update()
    {

        if (isActive == false & Input.GetKeyDown(KeyCode.E))
        {

            flashLight.enabled = true; //enables it when i press E
            isActive = true;

        }
        else if (isActive == true & Input.GetKeyDown(KeyCode.E)) {

            flashLight.enabled = false; //disables it when i re-press E
            isActive = false;

        }




    }
}
