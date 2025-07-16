using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    void Start()
    {
        if (cube != null)
        {
            Rigidbody cubeRb = cube.GetComponent<Rigidbody>();
            if (cubeRb != null)
            {
                cubeRb.useGravity = false;
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
