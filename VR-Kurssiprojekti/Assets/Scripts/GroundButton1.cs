using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundButton1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cube1")
        {
            Debug.Log("Cube osui");
            Destroy(GameObject.FindWithTag("Door1"));
        }
    }
}
