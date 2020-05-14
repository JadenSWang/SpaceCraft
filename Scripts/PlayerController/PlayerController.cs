using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
   
    // keyboard movement settings
    public float MovementSpeed;
    public int BoostMultiplier = 2;

    // mouse look settings
    public float MouseSensitivity = 100f;
    public Transform MainCamera;


    private PlayerControls inputController;
    
    // keyboard
    private float boosting = 1;
    private Vector2 lateralVector;
    private float verticalVector;
    // mouse
    private float xRotation;
    private Vector2 mousePos;

    public void Awake()
    {
        inputController = new PlayerControls();
        inputController.CharacterControls.MoveLaterally.performed += (context) => lateralVector = context.ReadValue<Vector2>();
        inputController.CharacterControls.MoveVertically.performed += context => verticalVector = context.ReadValue<float>();
        inputController.CharacterControls.Boost.performed += context => boosting = context.ReadValue<float>() > 0 ? BoostMultiplier : 1;
        inputController.CharacterControls.Look.performed += context => mousePos = context.ReadValue<Vector2>();
    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Update()
    {
        Move();
        MouseLook();
    }

    public void Move()
    {
        Vector3 move = transform.right * lateralVector.x + transform.forward * lateralVector.y + transform.up * verticalVector;
        controller.Move(move * MovementSpeed * boosting * Time.deltaTime);
    }

    public void MouseLook()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            float mouseX = mousePos.x * MouseSensitivity * Time.deltaTime;
            float mouseY = mousePos.y * MouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            MainCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.Rotate(new Vector3(0, mouseX, 0), Space.Self);
        }
    }

    private void OnEnable()
    {
        inputController.Enable();
    }

    private void OnDisable()
    {
        inputController.Disable();
    }
}
