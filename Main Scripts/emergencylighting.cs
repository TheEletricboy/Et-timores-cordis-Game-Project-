using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emergencylighting : MonoBehaviour
{

    public float rotationSpeed = 450f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * rotationSpeed, 0f)); //literally rotates de game object on the y axis
    }
}
