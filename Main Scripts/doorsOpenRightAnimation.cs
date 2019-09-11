using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsOpenRightAnimation : MonoBehaviour
{
    //lets me select the animator within Unity editor
    [SerializeField] private Animator myAnimationRight;
    [SerializeField] private AudioSource soundSource; //same as before but with an audio source game object


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //if the tag = Player (which was given to the player gameObject)
        {


            myAnimationRight.SetBool("playOpenRight", true); //set the bool on the animation to true which will change state from default to open
            soundSource.Play(); //plays the sound chosen
            myAnimationRight.SetFloat("speed", 1f); //sets the animation to "forward"
        }

    }

    private void OnTriggerExit(Collider other) //same as above for all
    {
        if (other.CompareTag("Player"))
        {


            myAnimationRight.SetBool("playOpenRight", false);
            soundSource.Play();
            myAnimationRight.SetFloat("speed", -1f); //plays the animation backwards giving a closing animation
        }

    }
}
