//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/Gizmo/GizmoActions.inputactions
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

public partial class @GizmoActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GizmoActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GizmoActions"",
    ""maps"": [
        {
            ""name"": ""GizmoMap"",
            ""id"": ""f992e7e7-b480-423e-a248-74ae1f96a2af"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f5655d6d-fecb-46c8-bae4-1e52798bbb7d"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""51d0f4ac-0f87-47ec-a0a5-afd3b1630633"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""56f590c2-0d2b-487d-b0af-9e429ef89ced"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""6b210162-5ddb-4d39-a9b2-d1b9023978ce"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""819b014a-7a44-4b2f-b687-44a4f982ee3b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4b0645f6-0fde-4639-8293-74e3f7962d36"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""36a19898-6357-4341-ac1c-883a481428ac"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""2af59ead-68d5-48d6-86c6-0a7c3a5f3f64"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4ee95148-d7d0-4f44-870e-dbb5d59a5dda"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f69e72e-088d-4b4e-b67e-d7d3c19a278d"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GizmoMap
        m_GizmoMap = asset.FindActionMap("GizmoMap", throwIfNotFound: true);
        m_GizmoMap_Movement = m_GizmoMap.FindAction("Movement", throwIfNotFound: true);
        m_GizmoMap_Jump = m_GizmoMap.FindAction("Jump", throwIfNotFound: true);
        m_GizmoMap_Attack = m_GizmoMap.FindAction("Attack", throwIfNotFound: true);
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

    // GizmoMap
    private readonly InputActionMap m_GizmoMap;
    private List<IGizmoMapActions> m_GizmoMapActionsCallbackInterfaces = new List<IGizmoMapActions>();
    private readonly InputAction m_GizmoMap_Movement;
    private readonly InputAction m_GizmoMap_Jump;
    private readonly InputAction m_GizmoMap_Attack;
    public struct GizmoMapActions
    {
        private @GizmoActions m_Wrapper;
        public GizmoMapActions(@GizmoActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GizmoMap_Movement;
        public InputAction @Jump => m_Wrapper.m_GizmoMap_Jump;
        public InputAction @Attack => m_Wrapper.m_GizmoMap_Attack;
        public InputActionMap Get() { return m_Wrapper.m_GizmoMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GizmoMapActions set) { return set.Get(); }
        public void AddCallbacks(IGizmoMapActions instance)
        {
            if (instance == null || m_Wrapper.m_GizmoMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GizmoMapActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
        }

        private void UnregisterCallbacks(IGizmoMapActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
        }

        public void RemoveCallbacks(IGizmoMapActions instance)
        {
            if (m_Wrapper.m_GizmoMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGizmoMapActions instance)
        {
            foreach (var item in m_Wrapper.m_GizmoMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GizmoMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GizmoMapActions @GizmoMap => new GizmoMapActions(this);
    public interface IGizmoMapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
