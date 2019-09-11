using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Emitter : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator myAnimation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            //emits sound
            audioSource.Play();
            myAnimation.SetBool("activate_animation", true); //activates animation from animator value in editor



        }

    }


}
