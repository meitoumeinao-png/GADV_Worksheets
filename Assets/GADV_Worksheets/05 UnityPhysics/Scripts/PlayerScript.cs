

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    CharacterController controller;

    // Your variables used for moving the player

    // [Movement variables]
    public float moveSpeed = 5f;
    public float jumpHeight = 2f;
    private Vector3 moveDirection;
    private float gravity = -9.81f;
    private Vector3 velocity;
    //Kick
    public float kickStrength = 10f; 
    public float kickDistance = 2f; 
    public float kickRadius = 1f; 

    // [Explosion variables]
    public float radius = 5.0f;
    public float power = 10000.0f;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false; // See comment about this!
    }

    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Create explosion at player's position
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);

            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // Apply explosion force to each rigidbody
                    rb.AddExplosionForce(power, explosionPos, radius, 3.0f);
                }
            }
        }
    }
    void Kick()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Calculate position in front of player
            Vector3 kickPosition = transform.position + transform.forward * kickDistance;

            // Find all colliders in the kick zone
            Collider[] colliders = Physics.OverlapSphere(kickPosition, kickRadius);

            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // Apply force in player's forward direction
                    rb.AddForce(transform.forward * kickStrength, ForceMode.Impulse);
                }
            }
        }
    }

    void FixedUpdate()
    {
        CheckExplosion();
        Kick();
        //PlayerMovement
        //[WASD Movement Input]
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        // Calculate movement direction
        moveDirection = transform.right * x + transform.forward * z;
        controller.Move(moveDirection * moveSpeed * Time.fixedDeltaTime);
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Small downward force to stay grounded
        }
    }
}
