// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerController/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Character Controls"",
            ""id"": ""ff01170a-2bce-4d6c-bf20-2f1dfa322075"",
            ""actions"": [
                {
                    ""name"": ""Move Laterally"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9af58154-9b17-4b5c-8d36-ae3bdeb0770e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Vertically"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8e2ec81c-04f3-4484-86d9-83147c7c76d5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cf854341-75fd-44a7-a773-b30b879948ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ff615d16-11b9-42a3-a9e5-c2132d450303"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""bb853bed-02c4-4157-bfb9-afa20f2bbbd7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Vertically"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5ccffc18-580d-489c-8e3b-3dff3865d1a0"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Vertically"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d1299efa-04fc-4d24-afa7-d02e9057cce3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Vertically"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""59c732c7-f192-46b5-a320-c6a090e6a511"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""51bdbbb9-87fb-4624-91d1-6e1f38e5e964"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Laterally"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""99802f1d-a791-4623-b386-1c80f22c7fc0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4e9ce338-28e3-4e33-8ad8-19c00d8fa149"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""39b03c94-3876-4223-88ab-0e2bb5afa8c4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eeb7bb7d-3cc0-4f49-8f9b-bd53533ee4ff"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""af35292f-08e9-4a55-b916-d8732ea6d70f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character Controls
        m_CharacterControls = asset.FindActionMap("Character Controls", throwIfNotFound: true);
        m_CharacterControls_MoveLaterally = m_CharacterControls.FindAction("Move Laterally", throwIfNotFound: true);
        m_CharacterControls_MoveVertically = m_CharacterControls.FindAction("Move Vertically", throwIfNotFound: true);
        m_CharacterControls_Boost = m_CharacterControls.FindAction("Boost", throwIfNotFound: true);
        m_CharacterControls_Look = m_CharacterControls.FindAction("Look", throwIfNotFound: true);
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

    // Character Controls
    private readonly InputActionMap m_CharacterControls;
    private ICharacterControlsActions m_CharacterControlsActionsCallbackInterface;
    private readonly InputAction m_CharacterControls_MoveLaterally;
    private readonly InputAction m_CharacterControls_MoveVertically;
    private readonly InputAction m_CharacterControls_Boost;
    private readonly InputAction m_CharacterControls_Look;
    public struct CharacterControlsActions
    {
        private @PlayerControls m_Wrapper;
        public CharacterControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLaterally => m_Wrapper.m_CharacterControls_MoveLaterally;
        public InputAction @MoveVertically => m_Wrapper.m_CharacterControls_MoveVertically;
        public InputAction @Boost => m_Wrapper.m_CharacterControls_Boost;
        public InputAction @Look => m_Wrapper.m_CharacterControls_Look;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControlsActions instance)
        {
            if (m_Wrapper.m_CharacterControlsActionsCallbackInterface != null)
            {
                @MoveLaterally.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMoveLaterally;
                @MoveLaterally.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMoveLaterally;
                @MoveLaterally.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMoveLaterally;
                @MoveVertically.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMoveVertically;
                @MoveVertically.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMoveVertically;
                @MoveVertically.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMoveVertically;
                @Boost.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnBoost;
                @Look.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_CharacterControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLaterally.started += instance.OnMoveLaterally;
                @MoveLaterally.performed += instance.OnMoveLaterally;
                @MoveLaterally.canceled += instance.OnMoveLaterally;
                @MoveVertically.started += instance.OnMoveVertically;
                @MoveVertically.performed += instance.OnMoveVertically;
                @MoveVertically.canceled += instance.OnMoveVertically;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public CharacterControlsActions @CharacterControls => new CharacterControlsActions(this);
    public interface ICharacterControlsActions
    {
        void OnMoveLaterally(InputAction.CallbackContext context);
        void OnMoveVertically(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
