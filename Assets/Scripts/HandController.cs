using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    public InputActionAsset playerController;

    InputAction LeftTriggerButton;
    InputAction LeftGripButton;
    InputAction ButtonA;
    InputAction ButtonB;

    InputAction RightTriggerButton;
    InputAction RightGripButton;
    InputAction ButtonX;
    InputAction ButtonY;

    public InputActionProperty LeftTriggerValue;
    public InputActionProperty LeftGripValue;
    public InputActionProperty LeftThumbValue;

    public InputActionProperty RightTriggerValue;
    public InputActionProperty RightGripValue;
    public InputActionProperty RightThumbValue;

    public InputActionProperty HMD_Position;
    public InputActionProperty HMD_Rotation;

    public Vector3 get_HMD_Position;
    public Quaternion get_HMD_Rotation;

    public float getLeftTriggerValue;
    public float getLeftGripValue;
    public Vector2 getLeftThumbValue;

    public float getRightTriggerValue;
    public float getRightGripValue;
    public Vector2 getRightThumbValue;

    private void Start()
    {
        var LeftHandAction = playerController.FindActionMap("XRI LeftHand Interaction");
        LeftTriggerButton = LeftHandAction.FindAction("Activate");
        LeftGripButton = LeftHandAction.FindAction("Select");
        ButtonA = LeftHandAction.FindAction("ButtonA");
        ButtonB = LeftHandAction.FindAction("ButtonB");

        LeftTriggerButton.performed += LeftTriggerFunction;
        LeftTriggerButton.Enable();

        LeftGripButton.performed += LeftGripFunction;
        LeftGripButton.Enable();

        ButtonA.performed += ButtonA_Function;
        ButtonA.Enable();

        ButtonB.performed += ButtonB_Function;
        ButtonB.Enable();

        var RightHandAction = playerController.FindActionMap("XRI RightHand Interaction");
        RightTriggerButton = RightHandAction.FindAction("Activate");
        RightGripButton = RightHandAction.FindAction("Select");
        ButtonX = RightHandAction.FindAction("ButtonX");
        ButtonY = RightHandAction.FindAction("ButtonY");

        RightTriggerButton.performed += RightTriggerFunction;
        RightTriggerButton.Enable();

        RightGripButton.performed += RightGripFunction;
        RightGripButton.Enable();

        ButtonX.performed += ButtonX_Function;
        ButtonX.Enable();

        ButtonY.performed += ButtonY_Function;
        ButtonY.Enable();

    }

    private void LeftTriggerFunction(InputAction.CallbackContext context)
    {
        Debug.Log("LeftTriggerButton");
    }
    private void LeftGripFunction(InputAction.CallbackContext context)
    {
        Debug.Log("LeftGripButton");
    }
    private void ButtonA_Function(InputAction.CallbackContext context)
    {
        Debug.Log("ButtonA");
    }
    private void ButtonB_Function(InputAction.CallbackContext context)
    {
        Debug.Log("ButtonB");
    }

    private void RightTriggerFunction(InputAction.CallbackContext context)
    {
        Debug.Log("RightTriggerButton");
    }
    private void RightGripFunction(InputAction.CallbackContext context)
    {
        Debug.Log("RightGripButton");
    }
    private void ButtonX_Function(InputAction.CallbackContext context)
    {
        Debug.Log("ButtonX");
    }
    private void ButtonY_Function(InputAction.CallbackContext context)
    {
        Debug.Log("ButtonY");
    }

    private void Update()
    {
        float triggerValueL = LeftTriggerValue.action.ReadValue<float>();
        getLeftTriggerValue = triggerValueL;
        float gripValueL = LeftGripValue.action.ReadValue<float>();
        getLeftGripValue = gripValueL;
        Vector2 thumbValueL = LeftThumbValue.action.ReadValue<Vector2>();
        getLeftThumbValue = thumbValueL;

        float triggerValueR = RightTriggerValue.action.ReadValue<float>();
        getRightTriggerValue = triggerValueR;
        float gripValueR = RightGripValue.action.ReadValue<float>();
        getRightGripValue = gripValueR;
        Vector2 thumbValueR = RightThumbValue.action.ReadValue<Vector2>();
        getRightThumbValue = thumbValueR;

        Vector3 HMD_Pos = HMD_Position.action.ReadValue<Vector3>();
        get_HMD_Position = HMD_Pos;
        Quaternion HMD_Rot = HMD_Rot = HMD_Rotation.action.ReadValue<Quaternion>();
        get_HMD_Rotation = HMD_Rot;
    }
}
