using UnityEngine;
using UnityEngine.Events;

public class HelicopterJoystickRelayMono : MonoBehaviour
{

    [Range(-1f, 1f)]
    public float m_rotateLeftRightValue;
    [Range(-1f, 1f)]
    public float m_frontalMoveValue;
    [Range(-1f, 1f)]
    public float m_verticalMoveValue;
    [Range(-1f, 1f)]
    public float m_horizontalRotationValue;

    public UnityEvent<float> m_onFrontalMove;
    public UnityEvent<float> m_onVerticalMove;
    public UnityEvent<float> m_onHorizontalMove;
    public UnityEvent<float> m_onLeftRightRotate;

    public bool m_useUpdate = true;

    public void Update()
    {
        if (m_useUpdate)
        {
            PushState();
        }
    }

    [ContextMenu("Refresh Push")]
    public void PushState()
    {
        SetFrontalMove(m_frontalMoveValue);
        SetVerticalMove(m_verticalMoveValue);
        SetHorizontalMove(m_horizontalRotationValue);
        SetLeftRightRotate(m_rotateLeftRightValue);
    }
    public void SetFrontalMove(float backForward)
    {
        m_frontalMoveValue = Mathf.Clamp(backForward, -1, 1);
        m_onFrontalMove.Invoke(m_frontalMoveValue);
    }
    public void SetVerticalMove(float upDown)
    {
        m_verticalMoveValue = Mathf.Clamp(upDown, -1, 1);
        m_onVerticalMove.Invoke(m_verticalMoveValue);
    }
    public void SetHorizontalMove(float leftRight)
    {
        m_horizontalRotationValue = Mathf.Clamp(leftRight, -1, 1);
        m_onHorizontalMove.Invoke(m_horizontalRotationValue);
    }
    public void SetLeftRightRotate(float rotateLeftRight)
    {
        m_rotateLeftRightValue = Mathf.Clamp(rotateLeftRight, -1, 1);
        m_onLeftRightRotate.Invoke(m_rotateLeftRightValue);
    }



}
