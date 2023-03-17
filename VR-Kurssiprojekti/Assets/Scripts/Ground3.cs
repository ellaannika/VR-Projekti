using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground3 : MonoBehaviour
{
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 3)
        {
            DestroyWall();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Kuutio1")
        {
            counter++;
        }
    }

    void DestroyWall()
    {
        Destroy(GameObject.FindWithTag("Door3"));
    }
}
