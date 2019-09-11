using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsOpenLeftAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationLeft; //CHECK RIGHT DOOR ANIMATION SCRIPT FOR MORE IN DEPTH AS IT IS LITERALLY THE SAME CODE
    //[SerializeField] private Animator myAnimationRight;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {

            myAnimationLeft.SetBool("playOpenLeft", true);
            myAnimationLeft.SetFloat("speed", 1f);
            //myAnimationRight.SetBool("playOpenRight", true);
            //myAnimationRight.SetFloat("speed", 1f);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            myAnimationLeft.SetBool("playOpenLeft", false);
            myAnimationLeft.SetFloat("speed", -1f);
            //myAnimationRight.SetBool("playOpenRight", false);
            //myAnimationRight.SetFloat("speed", -1f);

        }

    }






}
