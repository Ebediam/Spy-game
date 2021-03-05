// GENERATED AUTOMATICALLY FROM 'Assets/VRInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VRInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VRInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VRInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""de9840af-6e0b-463a-ad16-105dfa576414"",
            ""actions"": [
                {
                    ""name"": ""LeftThumbstick"",
                    ""type"": ""Value"",
                    ""id"": ""dca11024-3d86-4dd9-87f2-9d3fe0a6576f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightIndex"",
                    ""type"": ""Button"",
                    ""id"": ""e6a4aadc-3f77-4f67-a174-5bac41dd0611"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightThumbstick"",
                    ""type"": ""Value"",
                    ""id"": ""bb712a39-974d-4940-8bd5-2f12fd123221"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightThumbstickPress"",
                    ""type"": ""Button"",
                    ""id"": ""c3b0894d-d657-4981-b281-44b3b3f5ac17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftGrip"",
                    ""type"": ""Button"",
                    ""id"": ""01a18926-62a5-4cc3-a287-2878a246f6e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftIndex"",
                    ""type"": ""Button"",
                    ""id"": ""f7f45631-fb5d-4d51-a766-ea592fddfc40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightGrip"",
                    ""type"": ""Button"",
                    ""id"": ""bd57e4d0-33af-419a-a08a-28875d11e3d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""03d9c220-5468-4742-8c98-37b287a42220"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightIndex"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""292ce1c3-06b2-4530-939e-4132424dbe23"",
                    ""path"": ""<XRController>{LeftHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftThumbstick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fd51d1d-f1a3-4753-9c72-df24e1d39baa"",
                    ""path"": ""<XRController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightThumbstick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""440bed05-a2dd-4c0f-b328-c0d6529a5dc7"",
                    ""path"": ""<XRController>{RightHand}/thumbstickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightThumbstickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8b93783-a95d-4714-9ad5-1669814d258a"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3bbd59c-75fd-4508-bd88-dff4a678af04"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftIndex"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9a7bda2-3b57-4b4a-a762-ed8277f7126c"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Hacker"",
            ""id"": ""e69d31a3-8e45-481f-85f2-a1bb86849b6e"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""47e38709-d93d-44be-ac28-0d47cbea9866"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1b26b52a-746d-4f51-9e0f-8284777dc588"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e0a4d9b7-0d4f-4570-869d-e6b5d2d1f80b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9d2f90d-d2c8-4d9a-9d0e-8787ded17b0a"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LeftThumbstick = m_Player.FindAction("LeftThumbstick", throwIfNotFound: true);
        m_Player_RightIndex = m_Player.FindAction("RightIndex", throwIfNotFound: true);
        m_Player_RightThumbstick = m_Player.FindAction("RightThumbstick", throwIfNotFound: true);
        m_Player_RightThumbstickPress = m_Player.FindAction("RightThumbstickPress", throwIfNotFound: true);
        m_Player_LeftGrip = m_Player.FindAction("LeftGrip", throwIfNotFound: true);
        m_Player_LeftIndex = m_Player.FindAction("LeftIndex", throwIfNotFound: true);
        m_Player_RightGrip = m_Player.FindAction("RightGrip", throwIfNotFound: true);
        // Hacker
        m_Hacker = asset.FindActionMap("Hacker", throwIfNotFound: true);
        m_Hacker_Click = m_Hacker.FindAction("Click", throwIfNotFound: true);
        m_Hacker_Point = m_Hacker.FindAction("Point", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_LeftThumbstick;
    private readonly InputAction m_Player_RightIndex;
    private readonly InputAction m_Player_RightThumbstick;
    private readonly InputAction m_Player_RightThumbstickPress;
    private readonly InputAction m_Player_LeftGrip;
    private readonly InputAction m_Player_LeftIndex;
    private readonly InputAction m_Player_RightGrip;
    public struct PlayerActions
    {
        private @VRInput m_Wrapper;
        public PlayerActions(@VRInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftThumbstick => m_Wrapper.m_Player_LeftThumbstick;
        public InputAction @RightIndex => m_Wrapper.m_Player_RightIndex;
        public InputAction @RightThumbstick => m_Wrapper.m_Player_RightThumbstick;
        public InputAction @RightThumbstickPress => m_Wrapper.m_Player_RightThumbstickPress;
        public InputAction @LeftGrip => m_Wrapper.m_Player_LeftGrip;
        public InputAction @LeftIndex => m_Wrapper.m_Player_LeftIndex;
        public InputAction @RightGrip => m_Wrapper.m_Player_RightGrip;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @LeftThumbstick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftThumbstick;
                @LeftThumbstick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftThumbstick;
                @LeftThumbstick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftThumbstick;
                @RightIndex.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightIndex;
                @RightIndex.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightIndex;
                @RightIndex.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightIndex;
                @RightThumbstick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightThumbstick;
                @RightThumbstick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightThumbstick;
                @RightThumbstick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightThumbstick;
                @RightThumbstickPress.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightThumbstickPress;
                @RightThumbstickPress.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightThumbstickPress;
                @RightThumbstickPress.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightThumbstickPress;
                @LeftGrip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftGrip;
                @LeftGrip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftGrip;
                @LeftGrip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftGrip;
                @LeftIndex.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftIndex;
                @LeftIndex.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftIndex;
                @LeftIndex.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftIndex;
                @RightGrip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightGrip;
                @RightGrip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightGrip;
                @RightGrip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightGrip;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftThumbstick.started += instance.OnLeftThumbstick;
                @LeftThumbstick.performed += instance.OnLeftThumbstick;
                @LeftThumbstick.canceled += instance.OnLeftThumbstick;
                @RightIndex.started += instance.OnRightIndex;
                @RightIndex.performed += instance.OnRightIndex;
                @RightIndex.canceled += instance.OnRightIndex;
                @RightThumbstick.started += instance.OnRightThumbstick;
                @RightThumbstick.performed += instance.OnRightThumbstick;
                @RightThumbstick.canceled += instance.OnRightThumbstick;
                @RightThumbstickPress.started += instance.OnRightThumbstickPress;
                @RightThumbstickPress.performed += instance.OnRightThumbstickPress;
                @RightThumbstickPress.canceled += instance.OnRightThumbstickPress;
                @LeftGrip.started += instance.OnLeftGrip;
                @LeftGrip.performed += instance.OnLeftGrip;
                @LeftGrip.canceled += instance.OnLeftGrip;
                @LeftIndex.started += instance.OnLeftIndex;
                @LeftIndex.performed += instance.OnLeftIndex;
                @LeftIndex.canceled += instance.OnLeftIndex;
                @RightGrip.started += instance.OnRightGrip;
                @RightGrip.performed += instance.OnRightGrip;
                @RightGrip.canceled += instance.OnRightGrip;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Hacker
    private readonly InputActionMap m_Hacker;
    private IHackerActions m_HackerActionsCallbackInterface;
    private readonly InputAction m_Hacker_Click;
    private readonly InputAction m_Hacker_Point;
    public struct HackerActions
    {
        private @VRInput m_Wrapper;
        public HackerActions(@VRInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Hacker_Click;
        public InputAction @Point => m_Wrapper.m_Hacker_Point;
        public InputActionMap Get() { return m_Wrapper.m_Hacker; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HackerActions set) { return set.Get(); }
        public void SetCallbacks(IHackerActions instance)
        {
            if (m_Wrapper.m_HackerActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_HackerActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_HackerActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_HackerActionsCallbackInterface.OnClick;
                @Point.started -= m_Wrapper.m_HackerActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_HackerActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_HackerActionsCallbackInterface.OnPoint;
            }
            m_Wrapper.m_HackerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
            }
        }
    }
    public HackerActions @Hacker => new HackerActions(this);
    public interface IPlayerActions
    {
        void OnLeftThumbstick(InputAction.CallbackContext context);
        void OnRightIndex(InputAction.CallbackContext context);
        void OnRightThumbstick(InputAction.CallbackContext context);
        void OnRightThumbstickPress(InputAction.CallbackContext context);
        void OnLeftGrip(InputAction.CallbackContext context);
        void OnLeftIndex(InputAction.CallbackContext context);
        void OnRightGrip(InputAction.CallbackContext context);
    }
    public interface IHackerActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
    }
}
