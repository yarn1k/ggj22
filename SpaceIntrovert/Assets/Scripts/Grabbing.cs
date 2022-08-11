using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grabbing : MonoBehaviour
{
    [SerializeField] private int GRABI;

    private InputMaster inputMaster;
    private CharacterController controller;

    private RaycastHit hit;
    [SerializeField] private float grabPower = 10f;
    [SerializeField] private float throwPower = 10f;
    [SerializeField] private float rayDistance = 50f;

    private bool isGrab = false;
    private bool isThrow = false;
    public Transform offset;
    public Camera playerCamera;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();

        inputMaster = new InputMaster();
        inputMaster.Player.Enable();
        inputMaster.Player.Grab.performed += Grab_performed;
        inputMaster.Player.Throw.performed += Throw_performed;
    }

    private void Start()
    {
        GRABI = 0;
    }

    void FixedUpdate()
    {
        if (isGrab)
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.velocity = (offset.position - (hit.transform.position + hit.rigidbody.centerOfMass)) * grabPower;

            }
        }

        if (isThrow)
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.velocity = playerCamera.ScreenPointToRay(inputMaster.Player.MousePosition.ReadValue<Vector2>()).direction * throwPower;
                isThrow = false;
            }
        }
    }

    private void Grab_performed(InputAction.CallbackContext context)
    {
        Ray ray = playerCamera.ScreenPointToRay(inputMaster.Player.MousePosition.ReadValue<Vector2>());
        Physics.Raycast(ray, out hit, rayDistance);
        if (hit.rigidbody)
        {
            GRABI += 1;
            switch (GRABI)
            {
                case 1:
                    isGrab = true;
                    break;
                case 2:
                    isGrab = false;
                    break;
                default:
                    break;
            }
            if (GRABI == 3 || isGrab == false)
            {
                GRABI = 0;
            }
        }
        Debug.Log(GRABI);
    }

    private void Grab()
    {
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit, rayDistance);
        if (hit.rigidbody)
        {
            isGrab = true;
        }
    }

    private void Throw_performed(InputAction.CallbackContext context)
    {
        if (isGrab)
        {
            GRABI = 0;
            isGrab = false;
            isThrow = true;
        }
    } 
}
