//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Code/Scripts/Engine/Controls/ThirdView/ThirdView.inputactions
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

public partial class @ThirdView: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ThirdView()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ThirdView"",
    ""maps"": [
        {
            ""name"": ""Walking"",
            ""id"": ""74164175-f9c3-451f-acfa-7567ed73638b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c6346fdc-a618-408e-9b87-d4081a754811"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c3839931-2771-4f10-9a35-6e425ef0c0af"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""a797263f-d771-4568-a141-f8932df3b9ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""6eb8a447-6e44-4f0d-aff5-5c4dc8cab049"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""455bdd91-48fe-4965-93d4-e9afd530ef30"",
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
                    ""id"": ""344a2ed2-b5b3-40bc-b5b2-e4642bfd17ef"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0daf6084-a6e2-48c3-9615-a0c1883b0aa9"",
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
                    ""id"": ""abba9eeb-485b-40e5-ba76-413f2a5a4a22"",
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
                    ""id"": ""267678b1-b7f5-44f2-ae9a-565b7fdbf707"",
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
                    ""id"": ""c8a46a69-c6c0-4e79-8513-bbc247da43bf"",
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
                    ""id"": ""ddee8ede-7dc5-4dc8-870e-faa99fcb083b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a68b4fd-d268-419e-9453-fec77899b491"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27b71388-3f1f-4e8b-95d2-a0676c6559e3"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8172071c-613e-4b6b-8b80-aa29ee1cb7ca"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e12d65d-fc2c-46cb-876b-843518f89b2b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94e3473e-bfd0-491f-9995-82a2e4d912c2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""8c312c44-252b-4694-9410-8b803140381e"",
            ""actions"": [
                {
                    ""name"": ""ToggleMenu"",
                    ""type"": ""Button"",
                    ""id"": ""2f5667ee-f72a-4c87-ab1d-6af0439d822e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b9cd7d9b-44d6-4ce9-a8d4-237c4c3ee62b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51d7cbda-dd3c-4283-bb3e-3d56450aab10"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interactions"",
            ""id"": ""3a1f5f24-5430-4eb7-a3a4-522c29096b98"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""313b610c-25cb-4713-b63a-fb79eb4452cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95e6d066-5910-4b36-bce4-1820fead6858"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""354d35f4-2198-469b-86c4-e59ad2aa9d98"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Walking
        m_Walking = asset.FindActionMap("Walking", throwIfNotFound: true);
        m_Walking_Move = m_Walking.FindAction("Move", throwIfNotFound: true);
        m_Walking_Look = m_Walking.FindAction("Look", throwIfNotFound: true);
        m_Walking_Run = m_Walking.FindAction("Run", throwIfNotFound: true);
        m_Walking_Roll = m_Walking.FindAction("Roll", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_ToggleMenu = m_Inventory.FindAction("ToggleMenu", throwIfNotFound: true);
        // Interactions
        m_Interactions = asset.FindActionMap("Interactions", throwIfNotFound: true);
        m_Interactions_Interact = m_Interactions.FindAction("Interact", throwIfNotFound: true);
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

    // Walking
    private readonly InputActionMap m_Walking;
    private List<IWalkingActions> m_WalkingActionsCallbackInterfaces = new List<IWalkingActions>();
    private readonly InputAction m_Walking_Move;
    private readonly InputAction m_Walking_Look;
    private readonly InputAction m_Walking_Run;
    private readonly InputAction m_Walking_Roll;
    public struct WalkingActions
    {
        private @ThirdView m_Wrapper;
        public WalkingActions(@ThirdView wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Walking_Move;
        public InputAction @Look => m_Wrapper.m_Walking_Look;
        public InputAction @Run => m_Wrapper.m_Walking_Run;
        public InputAction @Roll => m_Wrapper.m_Walking_Roll;
        public InputActionMap Get() { return m_Wrapper.m_Walking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkingActions set) { return set.Get(); }
        public void AddCallbacks(IWalkingActions instance)
        {
            if (instance == null || m_Wrapper.m_WalkingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WalkingActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Roll.started += instance.OnRoll;
            @Roll.performed += instance.OnRoll;
            @Roll.canceled += instance.OnRoll;
        }

        private void UnregisterCallbacks(IWalkingActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Roll.started -= instance.OnRoll;
            @Roll.performed -= instance.OnRoll;
            @Roll.canceled -= instance.OnRoll;
        }

        public void RemoveCallbacks(IWalkingActions instance)
        {
            if (m_Wrapper.m_WalkingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWalkingActions instance)
        {
            foreach (var item in m_Wrapper.m_WalkingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WalkingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WalkingActions @Walking => new WalkingActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private List<IInventoryActions> m_InventoryActionsCallbackInterfaces = new List<IInventoryActions>();
    private readonly InputAction m_Inventory_ToggleMenu;
    public struct InventoryActions
    {
        private @ThirdView m_Wrapper;
        public InventoryActions(@ThirdView wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleMenu => m_Wrapper.m_Inventory_ToggleMenu;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void AddCallbacks(IInventoryActions instance)
        {
            if (instance == null || m_Wrapper.m_InventoryActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InventoryActionsCallbackInterfaces.Add(instance);
            @ToggleMenu.started += instance.OnToggleMenu;
            @ToggleMenu.performed += instance.OnToggleMenu;
            @ToggleMenu.canceled += instance.OnToggleMenu;
        }

        private void UnregisterCallbacks(IInventoryActions instance)
        {
            @ToggleMenu.started -= instance.OnToggleMenu;
            @ToggleMenu.performed -= instance.OnToggleMenu;
            @ToggleMenu.canceled -= instance.OnToggleMenu;
        }

        public void RemoveCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInventoryActions instance)
        {
            foreach (var item in m_Wrapper.m_InventoryActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InventoryActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);

    // Interactions
    private readonly InputActionMap m_Interactions;
    private List<IInteractionsActions> m_InteractionsActionsCallbackInterfaces = new List<IInteractionsActions>();
    private readonly InputAction m_Interactions_Interact;
    public struct InteractionsActions
    {
        private @ThirdView m_Wrapper;
        public InteractionsActions(@ThirdView wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Interactions_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Interactions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
        public void AddCallbacks(IInteractionsActions instance)
        {
            if (instance == null || m_Wrapper.m_InteractionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InteractionsActionsCallbackInterfaces.Add(instance);
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IInteractionsActions instance)
        {
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IInteractionsActions instance)
        {
            if (m_Wrapper.m_InteractionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInteractionsActions instance)
        {
            foreach (var item in m_Wrapper.m_InteractionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InteractionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InteractionsActions @Interactions => new InteractionsActions(this);
    public interface IWalkingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnToggleMenu(InputAction.CallbackContext context);
    }
    public interface IInteractionsActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
}
