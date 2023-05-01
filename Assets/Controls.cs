//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""ac74d271-3eb9-4b8d-8622-e9d3b89a1c0f"",
            ""actions"": [
                {
                    ""name"": ""Pedal / Reverse"",
                    ""type"": ""Value"",
                    ""id"": ""39900c6e-33d8-4791-a765-615839d34e6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""24cbfaf4-7374-4548-9d70-e529c323ad7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""d46b1d43-eb8d-49a0-86c8-a865f8fecbca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Package Mode"",
                    ""type"": ""Button"",
                    ""id"": ""415203c1-1bbb-420a-80d9-60856f09830c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard 1"",
                    ""id"": ""d6188fd9-db60-4811-9527-f426868078ce"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal / Reverse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""27f9f02f-05bf-4694-be69-48e360fe10bd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal / Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3330ea6f-f358-40a8-a95e-b39f2edcebbf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal / Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard 2"",
                    ""id"": ""31bc14a3-4efc-406b-a93c-8d5fae56b5aa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal / Reverse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c3f878eb-f40f-4e8d-9c36-47e306f3c9a4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal / Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3d5d9abc-58d0-40a2-a56d-bc1c18e89acc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal / Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard 1"",
                    ""id"": ""5a037141-40bd-4c90-a584-af561e8accbc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""64dce0d1-9869-47b7-bdf1-0788da067d72"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b6ae50d3-16a8-421a-81b9-b6ce796fce1e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard 2"",
                    ""id"": ""ddb64408-fcfb-4e77-86fc-1fbde074cb62"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7deb9c60-66bc-4a1b-bd0f-427a0048ffa8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4b656c87-7fe8-4bcd-bfbe-be080fb43b63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2b370a78-9103-4eda-a5cc-bee6bb38656c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e21b0b68-4e97-4218-921e-74b4855724e5"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Package Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_PedalReverse = m_Driving.FindAction("Pedal / Reverse", throwIfNotFound: true);
        m_Driving_Steer = m_Driving.FindAction("Steer", throwIfNotFound: true);
        m_Driving_Brake = m_Driving.FindAction("Brake", throwIfNotFound: true);
        m_Driving_PackageMode = m_Driving.FindAction("Package Mode", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Driving
    private readonly InputActionMap m_Driving;
    private List<IDrivingActions> m_DrivingActionsCallbackInterfaces = new List<IDrivingActions>();
    private readonly InputAction m_Driving_PedalReverse;
    private readonly InputAction m_Driving_Steer;
    private readonly InputAction m_Driving_Brake;
    private readonly InputAction m_Driving_PackageMode;
    public struct DrivingActions
    {
        private @Controls m_Wrapper;
        public DrivingActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PedalReverse => m_Wrapper.m_Driving_PedalReverse;
        public InputAction @Steer => m_Wrapper.m_Driving_Steer;
        public InputAction @Brake => m_Wrapper.m_Driving_Brake;
        public InputAction @PackageMode => m_Wrapper.m_Driving_PackageMode;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void AddCallbacks(IDrivingActions instance)
        {
            if (instance == null || m_Wrapper.m_DrivingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DrivingActionsCallbackInterfaces.Add(instance);
            @PedalReverse.started += instance.OnPedalReverse;
            @PedalReverse.performed += instance.OnPedalReverse;
            @PedalReverse.canceled += instance.OnPedalReverse;
            @Steer.started += instance.OnSteer;
            @Steer.performed += instance.OnSteer;
            @Steer.canceled += instance.OnSteer;
            @Brake.started += instance.OnBrake;
            @Brake.performed += instance.OnBrake;
            @Brake.canceled += instance.OnBrake;
            @PackageMode.started += instance.OnPackageMode;
            @PackageMode.performed += instance.OnPackageMode;
            @PackageMode.canceled += instance.OnPackageMode;
        }

        private void UnregisterCallbacks(IDrivingActions instance)
        {
            @PedalReverse.started -= instance.OnPedalReverse;
            @PedalReverse.performed -= instance.OnPedalReverse;
            @PedalReverse.canceled -= instance.OnPedalReverse;
            @Steer.started -= instance.OnSteer;
            @Steer.performed -= instance.OnSteer;
            @Steer.canceled -= instance.OnSteer;
            @Brake.started -= instance.OnBrake;
            @Brake.performed -= instance.OnBrake;
            @Brake.canceled -= instance.OnBrake;
            @PackageMode.started -= instance.OnPackageMode;
            @PackageMode.performed -= instance.OnPackageMode;
            @PackageMode.canceled -= instance.OnPackageMode;
        }

        public void RemoveCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDrivingActions instance)
        {
            foreach (var item in m_Wrapper.m_DrivingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DrivingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);
    public interface IDrivingActions
    {
        void OnPedalReverse(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnPackageMode(InputAction.CallbackContext context);
    }
}
