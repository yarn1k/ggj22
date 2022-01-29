using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    private PlayerInput controls;

    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    private void Awake()
    {
        controls = GetComponent<PlayerInput>();

        InputMaster inputMaster = new InputMaster();
        inputMaster.Player.Enable();
        inputMaster.Player.Mouse.performed += LookAround_performed;
    }

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void LookAround_performed(InputAction.CallbackContext context)
    {
        float mouseX = context.ReadValue<Vector2>().x * mouseSensitivity * Time.fixedDeltaTime;
        float mouseY = context.ReadValue<Vector2>().y * mouseSensitivity * Time.fixedDeltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    /*private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }*/
}
