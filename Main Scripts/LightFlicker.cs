using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    [SerializeField] private Light lightasset;

    // Update is called once per frame
    void Update()
    {
        if (Random.value > 0.9) //using a random value bigger than 0.9
        {
            if (lightasset.enabled == true) //if the light is enabled then disable it
            {
                lightasset.enabled = false;
            }
            else
            {
                lightasset.enabled = true; //else enable it again, begins looping endlessly with no compromises on performance
            }
        }
    }
}
