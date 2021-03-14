// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerMovement/main_controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Main_controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Main_controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""main_controller"",
    ""maps"": [
        {
            ""name"": ""Playermain"",
            ""id"": ""4f7d34b8-e8d1-437d-99fe-b9ffd80a6506"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4e33e6bb-674c-4423-9f06-33b1814d4cea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""5e6b76ed-f057-47d3-9459-3e5c5a22df80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""36632162-be66-4773-aca7-73243e2f26ac"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""415049c1-6fec-4689-a89e-badf095221cd"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8e18a571-ab0b-49ec-8461-de07f6135ba0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4ba6ffb0-f81c-4e47-b1a0-528cde93adfc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a99836f3-5a82-4e95-b198-ba93ed81f9a4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""148cb2bb-216a-44f1-bc7f-9c6e92c15dcd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""23fe810b-2ae5-4cfd-9029-13c8c7739972"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""9e309553-c63e-43cd-8162-bfa793472d7f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9e9137d1-b28c-448f-800c-c8342c89251b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""228d5549-e98c-4b66-bb49-3d985256749c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Playermain
        m_Playermain = asset.FindActionMap("Playermain", throwIfNotFound: true);
        m_Playermain_Move = m_Playermain.FindAction("Move", throwIfNotFound: true);
        m_Playermain_Attack = m_Playermain.FindAction("Attack", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Move = m_Camera.FindAction("Move", throwIfNotFound: true);
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

    // Playermain
    private readonly InputActionMap m_Playermain;
    private IPlayermainActions m_PlayermainActionsCallbackInterface;
    private readonly InputAction m_Playermain_Move;
    private readonly InputAction m_Playermain_Attack;
    public struct PlayermainActions
    {
        private @Main_controller m_Wrapper;
        public PlayermainActions(@Main_controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Playermain_Move;
        public InputAction @Attack => m_Wrapper.m_Playermain_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Playermain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayermainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayermainActions instance)
        {
            if (m_Wrapper.m_PlayermainActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_PlayermainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public PlayermainActions @Playermain => new PlayermainActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Move;
    public struct CameraActions
    {
        private @Main_controller m_Wrapper;
        public CameraActions(@Main_controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Camera_Move;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IPlayermainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
