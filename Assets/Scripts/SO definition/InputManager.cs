using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu]
public class InputManager : ScriptableObject
{

    private VRInput controls;

    public delegate void InputVoidEvent();
    public delegate void InputVector2Event(Vector2 vector);
    public delegate void InputFloatEvent(float value);
    public delegate void InputBoolEvent(bool value);


    public static InputVector2Event RightThumbstickEvent;
    public static InputVector2Event LeftThumbstickEvent;


    public static InputBoolEvent LeftGripEvent;
    public static InputBoolEvent RightGripEvent;
    public static InputBoolEvent LeftIndexEvent;
    public static InputBoolEvent RightIndexEvent;

    public static InputBoolEvent RightThumbstickPressEvent;

    public static InputVector2Event CameraMovementEvent;

    public static InputVector2Event ClickEvent;


    public static Vector2 mousePosition;




    private void OnEnable()
    {
        Debug.Log("InputManager enabled");
        controls = new VRInput();

        controls.Enable();

        controls.Player.LeftGrip.performed += LeftGrip;
        controls.Player.RightGrip.performed += RightGrip;
        controls.Player.LeftIndex.performed += LeftIndex;
        controls.Player.RightIndex.performed += RightIndex;
        controls.Player.LeftThumbstick.performed += LeftThumbstick;
        controls.Player.RightThumbstick.performed += RightThumbstick;
        controls.Player.RightThumbstickPress.performed += RightThumbstickPress;

        controls.Player.LeftGrip.canceled += LeftGripCancel;
        controls.Player.RightGrip.canceled += RightGripCancel;
        controls.Player.LeftIndex.canceled += LeftIndexCancel;
        controls.Player.RightIndex.canceled += RightIndexCancel;
        controls.Player.LeftThumbstick.canceled += LeftThumbstickCancel;
        controls.Player.RightThumbstick.canceled += RightThumbstickCancel;
        controls.Player.RightThumbstickPress.canceled += RightThumbstickPressCancel;

        controls.Hacker.CameraMovement.performed += CameraMovement;
        controls.Hacker.CameraMovement.canceled += CameraMovementStop;

        controls.Hacker.Click.performed += Click;
        controls.Hacker.Point.performed += MousePosition;

    }

    private void OnDisable()
    {
        controls.Disable();

        controls.Player.LeftGrip.performed -= LeftGrip;
        controls.Player.RightGrip.performed -= RightGrip;
        controls.Player.LeftIndex.performed -= LeftIndex;
        controls.Player.RightIndex.performed -= RightIndex;
        controls.Player.LeftThumbstick.performed -= LeftThumbstick;
        controls.Player.RightThumbstick.performed -= RightThumbstick;
        controls.Player.RightThumbstickPress.performed -= RightThumbstickPress;

        controls.Player.LeftGrip.canceled -= LeftGripCancel;
        controls.Player.RightGrip.canceled -= RightGripCancel;
        controls.Player.LeftIndex.canceled -= LeftIndexCancel;
        controls.Player.RightIndex.canceled -= RightIndexCancel;
        controls.Player.LeftThumbstick.canceled -= LeftThumbstickCancel;
        controls.Player.RightThumbstick.canceled -= RightThumbstickCancel;
        controls.Player.RightThumbstickPress.canceled -= RightThumbstickPressCancel;

        controls.Hacker.CameraMovement.performed -= CameraMovement;
        controls.Hacker.CameraMovement.canceled -= CameraMovementStop;

        controls.Hacker.Click.performed -= Click;


    }

    // ---------------------------- PERFORMED INPUTS ----------------------------

    private void LeftGrip(InputAction.CallbackContext ctxt)
    {
        LeftGripEvent?.Invoke(true);
    }

    private void RightGrip(InputAction.CallbackContext ctxt)
    {
        RightGripEvent?.Invoke(true);
    }

    private void LeftIndex(InputAction.CallbackContext ctxt)
    {
        LeftIndexEvent?.Invoke(true);
    }

    private void RightIndex(InputAction.CallbackContext ctxt)
    {
        RightIndexEvent?.Invoke(true);
    }

    private void LeftThumbstick(InputAction.CallbackContext ctxt)
    {
        Vector2 output = ctxt.ReadValue<Vector2>();
        LeftThumbstickEvent?.Invoke(output);
    }

    private void RightThumbstick(InputAction.CallbackContext ctxt)
    {
        Vector2 output = ctxt.ReadValue<Vector2>();
        RightThumbstickEvent?.Invoke(output);
    }


    private void RightThumbstickPress(InputAction.CallbackContext ctxt)
    {
        RightThumbstickPressEvent?.Invoke(true);
    }


    // ------------------- CANCEL INPUTS ---------------------


    private void LeftGripCancel(InputAction.CallbackContext ctxt)
    {
        LeftGripEvent?.Invoke(false);
    }

    private void RightGripCancel(InputAction.CallbackContext ctxt)
    {
        RightGripEvent?.Invoke(false);
    }

    private void LeftIndexCancel(InputAction.CallbackContext ctxt)
    {
        LeftIndexEvent?.Invoke(false);
    }

    private void RightIndexCancel(InputAction.CallbackContext ctxt)
    {
        RightIndexEvent?.Invoke(false);
    }

    private void LeftThumbstickCancel(InputAction.CallbackContext ctxt)
    {
        LeftThumbstickEvent?.Invoke(Vector2.zero);
    }

    private void RightThumbstickCancel(InputAction.CallbackContext ctxt)
    {
        RightThumbstickEvent?.Invoke(Vector2.zero);
    }

    private void RightThumbstickPressCancel(InputAction.CallbackContext ctxt)
    {
        RightThumbstickPressEvent?.Invoke(false);
    }

    private void CameraMovement(InputAction.CallbackContext ctxt)
    {
        Vector2 value = ctxt.ReadValue<Vector2>();
        CameraMovementEvent?.Invoke(value);

    }

    private void CameraMovementStop(InputAction.CallbackContext ctxt)
    {
        CameraMovementEvent?.Invoke(Vector2.zero);
    }

    private void Click(InputAction.CallbackContext ctxt)
    {
        ClickEvent?.Invoke(mousePosition);
    }

    private void MousePosition(InputAction.CallbackContext ctxt)
    {
        mousePosition = ctxt.ReadValue<Vector2>();

    }
}
