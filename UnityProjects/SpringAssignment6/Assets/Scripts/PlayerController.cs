/*
 * Liam Barrett
 * PlayerController.cs
 * Spring Assignment 6
 * Manages mouse and keyboard controls for the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    public Hand leftHand;
    public Hand rightHand;
    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;
    public float gravity = 9.8f;
    private float velocity = 0;

    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        MouseAiming();
        KeyboardMovement();
        if (Input.GetMouseButtonDown(0))
        {
            leftHand.spawnBlock();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rightHand.spawnBlock();
        }
    }

    void MouseAiming()
    {
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }

    void KeyboardMovement()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed;
        float vertical = Input.GetAxis("Vertical") * moveSpeed;
        characterController.Move((transform.right * horizontal + transform.forward * vertical) * Time.deltaTime);

        if (characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }
}
