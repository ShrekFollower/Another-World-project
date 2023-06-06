using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    public CharacterController controller;

    public float speed = 10f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    float sprintBar = 6;
    public float isSprinting;
    public float canSprint = 1;
    float timer = 0;

    Vector3 velocity;
    bool isGrounded;

    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;
    public Collider soundRadius;

    void Start()
    {
        canSprint = 1;
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1)
        {
            print(isSprinting);
            timer = 0;
        }
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift) && canSprint == 1)
        {
            speed = 15f;
            isSprinting = 1;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 10f;
            isSprinting = 0;
        }

        while(isSprinting == 1)
        {
            sprintBar -= Time.deltaTime;
            if(sprintBar <= 0)
            {
                canSprint = 0;
                isSprinting = 0;
            }
        }

        while(isSprinting == 0 && sprintBar != 6)
        {
            sprintBar += Time.deltaTime;
            if(sprintBar == 6)
            {
                canSprint = 1;
            }
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
