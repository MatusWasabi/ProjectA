//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerInput/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""MapExploration"",
            ""id"": ""b593a7f8-185d-4c48-b8c5-6b9a27b9d16e"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""3d5c645f-177b-4399-9cdd-68adb803dcd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a741d57-3fed-46bb-a963-0b01364d5605"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MapExploration
        m_MapExploration = asset.FindActionMap("MapExploration", throwIfNotFound: true);
        m_MapExploration_Click = m_MapExploration.FindAction("Click", throwIfNotFound: true);
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

    // MapExploration
    private readonly InputActionMap m_MapExploration;
    private List<IMapExplorationActions> m_MapExplorationActionsCallbackInterfaces = new List<IMapExplorationActions>();
    private readonly InputAction m_MapExploration_Click;
    public struct MapExplorationActions
    {
        private @PlayerInput m_Wrapper;
        public MapExplorationActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_MapExploration_Click;
        public InputActionMap Get() { return m_Wrapper.m_MapExploration; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapExplorationActions set) { return set.Get(); }
        public void AddCallbacks(IMapExplorationActions instance)
        {
            if (instance == null || m_Wrapper.m_MapExplorationActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MapExplorationActionsCallbackInterfaces.Add(instance);
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
        }

        private void UnregisterCallbacks(IMapExplorationActions instance)
        {
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
        }

        public void RemoveCallbacks(IMapExplorationActions instance)
        {
            if (m_Wrapper.m_MapExplorationActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMapExplorationActions instance)
        {
            foreach (var item in m_Wrapper.m_MapExplorationActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MapExplorationActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MapExplorationActions @MapExploration => new MapExplorationActions(this);
    public interface IMapExplorationActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
