using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // [Movement Settings]
    public float moveSpeed = 5f;
    public float mouseSensitivity = 100f;
    public float jumpForce = 5f;

    // [Explosion Settings]
    public float explosionRadius = 5f;
    public float explosionPower = 10000f;



    void Start()
    {

    }

    void Update()
    {

        // Handle explosion input
        if (Input.GetKeyDown(KeyCode.E))
        {
            CreateExplosion();
        }


    }

    void FixedUpdate()
    {

    }

    void CreateExplosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionPower, transform.position, explosionRadius);
            }
        }
    }
}
