using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    
    //mouseSens is a float variable that controls the speed at which the camera rotates.
    //it being public allows me to change the varuable through the unity editor without using code
    public float mouseSens = 100f;

    public string objective;

    //the playerBody variable is a transform variable that allows me
    //to change the position and rotation of the player.
    public Transform playerBody;

    //xRotation is a float variable that i created to control the rotation of the player camera!
    float xRotation = 0f; 

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
