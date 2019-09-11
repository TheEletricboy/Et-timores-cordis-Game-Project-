using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_Flicker : MonoBehaviour
{
    [SerializeField]private Text flickerText;


    // Start is called before the first frame update
    void Start()
    {

        flickerText = GetComponent<Text>(); //gets the text element at the start of the script
       
        StartCoroutine(UIFlicker());//starts countdown at the start



    }

    public IEnumerator UIFlicker()
    {

        while (true) //while loop
        {
            //disable text by displaying nothing
            flickerText.text = "";
            //timer for half a second
            yield return new WaitForSeconds(0.5f);
            //re-enable text
            flickerText.text = "DECREASING RAPIDLY";
            yield return new WaitForSeconds(.5f);
            //wait another .5 seconds
        }
    }
}



