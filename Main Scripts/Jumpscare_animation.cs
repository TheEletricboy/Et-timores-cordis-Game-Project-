using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare_animation : MonoBehaviour
{
    [SerializeField] private Animator myAnimation;
    [SerializeField] private AudioSource soundSource;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            myAnimation.SetBool("Collided_jumpscare", true);
            soundSource.Play();



        }

    }







}
