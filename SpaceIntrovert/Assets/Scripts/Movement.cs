using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private InputMaster inputMaster;
    private CharacterController controller;

    [SerializeField] private float speed = 12f;
    [SerializeField] private float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;

    private bool isMove;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();

        inputMaster = new InputMaster();
        inputMaster.Player.Enable();
        //inputMaster.Player.Movement.performed += Movement_performed;
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Movement_performed();
    }

    private void Movement_performed()
    {
        Vector2 inputVector = inputMaster.Player.Movement.ReadValue<Vector2>();
        float x = inputVector.x;
        float z = inputVector.y;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.fixedDeltaTime);

        velocity.y += gravity * Time.fixedDeltaTime;

        controller.Move(velocity);
    }
}
