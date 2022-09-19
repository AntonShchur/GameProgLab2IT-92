using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController CharacterController;
    public float characterSpeed;
    public bool isOnTheGround;
    public float distanceToTheGround = 0.1f;
    public Transform bottomPoint;
    public LayerMask groundLayerMask;
    public float maxJumpHeight = 80f;

    Vector3 velocity;
    public float gravity = 9.8f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveVector = transform.right * x + transform.forward * z;
        CharacterController.Move(moveVector * characterSpeed * Time.deltaTime);


        isOnTheGround = Physics.CheckSphere(bottomPoint.position, distanceToTheGround, groundLayerMask);
        

        if (isOnTheGround && velocity.y < 0)
        {
            velocity.y = -10f;
        }

        if (isOnTheGround && Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = Mathf.Sqrt(maxJumpHeight - 2f * gravity);

        }

        velocity.y -= gravity * Time.deltaTime;
        CharacterController.Move(velocity * Time.deltaTime / 2);

        
        

    }

}
