using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ItemFollowsMouse : MonoBehaviour
{
    public void Awake()
    {
        GameControls inputController = new GameControls();
        inputController.GameControl.CursorLocation.performed += ctx =>
        {
            Vector2 mousePos = ctx.ReadValue<Vector2>();
            transform.position = new Vector3(mousePos.x, mousePos.y, -10);
        };

        inputController.Enable();
    }
}
