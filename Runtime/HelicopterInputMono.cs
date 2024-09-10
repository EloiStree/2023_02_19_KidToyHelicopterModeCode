using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HelicopterInputMono : MonoBehaviour
{
    public HelicopterMono m_helicopterToAffect;
    public InputActionReference m_rotateLeftRight;
    public InputActionReference m_moveLeftRight;
    public InputActionReference m_moveBackFront;
    public InputActionReference m_moveDownUp;


    void OnEnable()
    {
        m_rotateLeftRight.action.Enable();
        m_moveLeftRight.action.Enable();
        m_moveBackFront.action.Enable();
        m_moveDownUp.action.Enable();
        m_rotateLeftRight.action.performed += RotateLeftRight;
        m_moveLeftRight.action.performed += MoveLeftRight;
        m_moveBackFront.action.performed += MoveBackFront;
        m_moveDownUp.action.performed += MoveDownUp;
        m_rotateLeftRight.action.canceled += RotateLeftRight;
        m_moveLeftRight.action.canceled += MoveLeftRight;
        m_moveBackFront.action.canceled += MoveBackFront;
        m_moveDownUp.action.canceled += MoveDownUp;
    }

    private void OnDisable()
    {
        m_rotateLeftRight.action.Disable();
        m_moveLeftRight.action.Disable();
        m_moveBackFront.action.Disable();
        m_moveDownUp.action.Disable();

        m_rotateLeftRight.action.performed -= RotateLeftRight;
        m_moveLeftRight.action.performed -= MoveLeftRight;
        m_moveBackFront.action.performed -= MoveBackFront;
        m_moveDownUp.action.performed -= MoveDownUp;
        m_rotateLeftRight.action.canceled -= RotateLeftRight;
        m_moveLeftRight.action.canceled -= MoveLeftRight;
        m_moveBackFront.action.canceled -= MoveBackFront;
        m_moveDownUp.action.canceled -= MoveDownUp;
    }

    private void MoveDownUp(InputAction.CallbackContext context)
    {
        m_helicopterToAffect.m_moveDownToUpPercent = context.ReadValue<float>();
    }

    private void MoveBackFront(InputAction.CallbackContext context)
    {
        m_helicopterToAffect.m_moveBackToFrontPercent = context.ReadValue<float>();
    }

    private void RotateLeftRight(InputAction.CallbackContext context)
    {
        m_helicopterToAffect.m_rotateLeftRightPercent = context.ReadValue<float>();
    }

    private void MoveLeftRight(InputAction.CallbackContext context)
    {
        m_helicopterToAffect.m_moveLeftToRightPercent = context.ReadValue<float>();
    }
}
