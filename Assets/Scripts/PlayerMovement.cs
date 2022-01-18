using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller; // Accesses character controller script 

    public float speed = 12f;
    public float gravity = -9.81f; // Applies gravity to player when falling
    public float jumpHeight = 3f; 
    

    public Transform groundCheck; // Add ground check object to Player 
    public float groundDistance = 0.4f; //Will become radius of the sphere that checks if player is on ground
    public LayerMask groundMask; // Will control what objects groundDistance will check for


    bool isGrounded;
    Vector3 velocity; 

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        // Creates the sphere at position of groundcheck transform, a radius of groundDistance, and uses a bool 

        if(isGrounded && velocity.y < 0) // Resets velocity once player isGrounded is true
        {
            velocity.y = -2f; 
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime); // Accesses character controller to reference directions

        if(Input.GetButtonDown("Jump") && isGrounded) // Checks if player is on ground and allows player to jump
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime; // Adds velocity to gravity making player fall at an increased rate

        controller.Move(velocity * Time.deltaTime);
    }
}
