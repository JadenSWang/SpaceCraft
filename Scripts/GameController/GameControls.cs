// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GameController/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Game Control"",
            ""id"": ""b2b8dad4-c8a4-4a01-9ed1-ac81703b146a"",
            ""actions"": [
                {
                    ""name"": ""CursorLocation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0e893e87-f6fd-4dc2-a0af-b04d5c42325f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Free Cursor"",
                    ""type"": ""Button"",
                    ""id"": ""87c5f8e5-a880-4049-b631-06fa541e5ac3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""695a3623-e602-491c-a392-11bae310bac1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnShip"",
                    ""type"": ""Button"",
                    ""id"": ""4e824d57-feca-42e0-bebb-776fc280e5d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnStation"",
                    ""type"": ""Button"",
                    ""id"": ""9f38fed2-eb56-4cae-a4f2-38a6a97f7868"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a95759d2-cf12-44ef-adfc-351060f9242d"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Free Cursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2216bcc-0ce2-4860-b1a7-4bbf28ab57d1"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11961cda-c41d-4eb3-91b0-5fa8b24df6c6"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnShip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe4f95da-7112-4888-a3c6-754a781de8e8"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnStation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dcf563f-b082-4a14-9a36-4c07742fec3b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorLocation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game Control
        m_GameControl = asset.FindActionMap("Game Control", throwIfNotFound: true);
        m_GameControl_CursorLocation = m_GameControl.FindAction("CursorLocation", throwIfNotFound: true);
        m_GameControl_FreeCursor = m_GameControl.FindAction("Free Cursor", throwIfNotFound: true);
        m_GameControl_Inventory = m_GameControl.FindAction("Inventory", throwIfNotFound: true);
        m_GameControl_SpawnShip = m_GameControl.FindAction("SpawnShip", throwIfNotFound: true);
        m_GameControl_SpawnStation = m_GameControl.FindAction("SpawnStation", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Game Control
    private readonly InputActionMap m_GameControl;
    private IGameControlActions m_GameControlActionsCallbackInterface;
    private readonly InputAction m_GameControl_CursorLocation;
    private readonly InputAction m_GameControl_FreeCursor;
    private readonly InputAction m_GameControl_Inventory;
    private readonly InputAction m_GameControl_SpawnShip;
    private readonly InputAction m_GameControl_SpawnStation;
    public struct GameControlActions
    {
        private @GameControls m_Wrapper;
        public GameControlActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CursorLocation => m_Wrapper.m_GameControl_CursorLocation;
        public InputAction @FreeCursor => m_Wrapper.m_GameControl_FreeCursor;
        public InputAction @Inventory => m_Wrapper.m_GameControl_Inventory;
        public InputAction @SpawnShip => m_Wrapper.m_GameControl_SpawnShip;
        public InputAction @SpawnStation => m_Wrapper.m_GameControl_SpawnStation;
        public InputActionMap Get() { return m_Wrapper.m_GameControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlActions instance)
        {
            if (m_Wrapper.m_GameControlActionsCallbackInterface != null)
            {
                @CursorLocation.started -= m_Wrapper.m_GameControlActionsCallbackInterface.OnCursorLocation;
                @CursorLocation.performed -= m_Wrapper.m_GameControlActionsCallbackInterface.OnCursorLocation;
                @CursorLocation.canceled -= m_Wrapper.m_GameControlActionsCallbackInterface.OnCursorLocation;
                @FreeCursor.started -= m_Wrapper.m_GameControlActionsCallbackInterface.OnFreeCursor;
                @FreeCursor.performed -= m_Wrapper.m_GameControlActionsCallbackInterface.OnFreeCursor;
                @FreeCursor.canceled -= m_Wrapper.m_GameControlActionsCallbackInterface.OnFreeCursor;
                @Inventory.started -= m_Wrapper.m_GameControlActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_GameControlActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_GameControlActionsCallbackInterface.OnInventory;
                @SpawnShip.started -= m_Wrapper.m_GameControlActionsCallbackInterface.OnSpawnShip;
                @SpawnShip.performed -= m_Wrapper.m_GameControlActionsCallbackInterface.OnSpawnShip;
                @SpawnShip.canceled -= m_Wrapper.m_GameControlActionsCallbackInterface.OnSpawnShip;
                @SpawnStation.started -= m_Wrapper.m_GameControlActionsCallbackInterface.OnSpawnStation;
                @SpawnStation.performed -= m_Wrapper.m_GameControlActionsCallbackInterface.OnSpawnStation;
                @SpawnStation.canceled -= m_Wrapper.m_GameControlActionsCallbackInterface.OnSpawnStation;
            }
            m_Wrapper.m_GameControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CursorLocation.started += instance.OnCursorLocation;
                @CursorLocation.performed += instance.OnCursorLocation;
                @CursorLocation.canceled += instance.OnCursorLocation;
                @FreeCursor.started += instance.OnFreeCursor;
                @FreeCursor.performed += instance.OnFreeCursor;
                @FreeCursor.canceled += instance.OnFreeCursor;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @SpawnShip.started += instance.OnSpawnShip;
                @SpawnShip.performed += instance.OnSpawnShip;
                @SpawnShip.canceled += instance.OnSpawnShip;
                @SpawnStation.started += instance.OnSpawnStation;
                @SpawnStation.performed += instance.OnSpawnStation;
                @SpawnStation.canceled += instance.OnSpawnStation;
            }
        }
    }
    public GameControlActions @GameControl => new GameControlActions(this);
    public interface IGameControlActions
    {
        void OnCursorLocation(InputAction.CallbackContext context);
        void OnFreeCursor(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnSpawnShip(InputAction.CallbackContext context);
        void OnSpawnStation(InputAction.CallbackContext context);
    }
}
