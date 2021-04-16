// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/main_controller.inputactions'

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
                },
                {
                    ""name"": ""skill1"",
                    ""type"": ""Button"",
                    ""id"": ""e5960b97-72a0-4d9d-a070-6625145c6a56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""skill2"",
                    ""type"": ""Button"",
                    ""id"": ""d3544e90-e257-4c84-af31-ab8e875f3742"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""skill3"",
                    ""type"": ""Button"",
                    ""id"": ""eb6acc64-140d-4bd9-8700-aa9563231c04"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""01014f8d-d5a1-4776-a73f-bfbf610089df"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81bed559-5430-4adf-94f2-a2d4ecaf257e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b213cf9f-f292-4421-a252-5575b641f031"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""skill3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7f23e4b-41ad-426c-bde4-1d44f554310e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""skill3"",
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
        m_Playermain_skill1 = m_Playermain.FindAction("skill1", throwIfNotFound: true);
        m_Playermain_skill2 = m_Playermain.FindAction("skill2", throwIfNotFound: true);
        m_Playermain_skill3 = m_Playermain.FindAction("skill3", throwIfNotFound: true);
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
    private readonly InputAction m_Playermain_skill1;
    private readonly InputAction m_Playermain_skill2;
    private readonly InputAction m_Playermain_skill3;
    public struct PlayermainActions
    {
        private @Main_controller m_Wrapper;
        public PlayermainActions(@Main_controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Playermain_Move;
        public InputAction @Attack => m_Wrapper.m_Playermain_Attack;
        public InputAction @skill1 => m_Wrapper.m_Playermain_skill1;
        public InputAction @skill2 => m_Wrapper.m_Playermain_skill2;
        public InputAction @skill3 => m_Wrapper.m_Playermain_skill3;
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
                @skill1.started -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill1;
                @skill1.performed -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill1;
                @skill1.canceled -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill1;
                @skill2.started -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill2;
                @skill2.performed -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill2;
                @skill2.canceled -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill2;
                @skill3.started -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill3;
                @skill3.performed -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill3;
                @skill3.canceled -= m_Wrapper.m_PlayermainActionsCallbackInterface.OnSkill3;
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
                @skill1.started += instance.OnSkill1;
                @skill1.performed += instance.OnSkill1;
                @skill1.canceled += instance.OnSkill1;
                @skill2.started += instance.OnSkill2;
                @skill2.performed += instance.OnSkill2;
                @skill2.canceled += instance.OnSkill2;
                @skill3.started += instance.OnSkill3;
                @skill3.performed += instance.OnSkill3;
                @skill3.canceled += instance.OnSkill3;
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
        void OnSkill1(InputAction.CallbackContext context);
        void OnSkill2(InputAction.CallbackContext context);
        void OnSkill3(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
