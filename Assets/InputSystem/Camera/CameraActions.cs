//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/Camera/CameraActions.inputactions
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

public partial class @CameraActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CameraActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CameraActions"",
    ""maps"": [
        {
            ""name"": ""CameraMap"",
            ""id"": ""454d1401-c44f-4969-b6c2-ff12c9e8dbeb"",
            ""actions"": [
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""450cfae0-488a-4eb1-819d-8c81e1401e1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""f8ea62dc-9d73-4c5f-be55-2a75fc073d7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a07b73c-43ff-42a0-ace2-0dcb5bc70a6d"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27a608fb-c1f0-4647-ad36-cc8a0084c527"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraMap
        m_CameraMap = asset.FindActionMap("CameraMap", throwIfNotFound: true);
        m_CameraMap_Previous = m_CameraMap.FindAction("Previous", throwIfNotFound: true);
        m_CameraMap_Next = m_CameraMap.FindAction("Next", throwIfNotFound: true);
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

    // CameraMap
    private readonly InputActionMap m_CameraMap;
    private List<ICameraMapActions> m_CameraMapActionsCallbackInterfaces = new List<ICameraMapActions>();
    private readonly InputAction m_CameraMap_Previous;
    private readonly InputAction m_CameraMap_Next;
    public struct CameraMapActions
    {
        private @CameraActions m_Wrapper;
        public CameraMapActions(@CameraActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Previous => m_Wrapper.m_CameraMap_Previous;
        public InputAction @Next => m_Wrapper.m_CameraMap_Next;
        public InputActionMap Get() { return m_Wrapper.m_CameraMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMapActions set) { return set.Get(); }
        public void AddCallbacks(ICameraMapActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraMapActionsCallbackInterfaces.Add(instance);
            @Previous.started += instance.OnPrevious;
            @Previous.performed += instance.OnPrevious;
            @Previous.canceled += instance.OnPrevious;
            @Next.started += instance.OnNext;
            @Next.performed += instance.OnNext;
            @Next.canceled += instance.OnNext;
        }

        private void UnregisterCallbacks(ICameraMapActions instance)
        {
            @Previous.started -= instance.OnPrevious;
            @Previous.performed -= instance.OnPrevious;
            @Previous.canceled -= instance.OnPrevious;
            @Next.started -= instance.OnNext;
            @Next.performed -= instance.OnNext;
            @Next.canceled -= instance.OnNext;
        }

        public void RemoveCallbacks(ICameraMapActions instance)
        {
            if (m_Wrapper.m_CameraMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraMapActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraMapActions @CameraMap => new CameraMapActions(this);
    public interface ICameraMapActions
    {
        void OnPrevious(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
    }
}
