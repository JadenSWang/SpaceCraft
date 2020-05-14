using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    public GameObject InventoryPanel;

    private GameControls gameInputController;

    public void Awake()
    {
        gameInputController = new GameControls();
        gameInputController.GameControl.FreeCursor.started += _ =>
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        };
        gameInputController.GameControl.FreeCursor.canceled += _ =>
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        };
        gameInputController.GameControl.Inventory.performed += _ =>
        {
            InventoryPanel.SetActive(!InventoryPanel.activeSelf);
            if (InventoryPanel.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        };
        gameInputController.GameControl.SpawnShip.performed += _ =>
        {
        };
        gameInputController.GameControl.SpawnStation.performed += _ =>
        {
        };

    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        gameInputController.Enable();
    }

    private void OnDisable()
    {
        gameInputController.Disable();
    }
}
