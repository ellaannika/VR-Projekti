using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundButton2 : MonoBehaviour
{
    public int counter = 0;

    void Update()
    {
        if (counter == 3)
        {
            DestroyWall();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube3")
        {
            counter++;
        }
    }

    void DestroyWall()
    {
        Destroy(GameObject.FindWithTag("Door2"));
    }
}
