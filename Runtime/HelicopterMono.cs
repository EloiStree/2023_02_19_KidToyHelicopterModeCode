using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMono : MonoBehaviour
{

    public Transform m_whatToMove;
    public float m_angleSpeedPerSecond = 90;

    public float m_moveSpeedPerSecond = 1;

    [Range(-1f, 1f)]
    [Tooltip("Rotate the helicoter in angle as percrent from -1 to 1")]
    public float m_rotateLeftRightPercent = 0;
    [Range(-1f, 1f)]
    public float m_moveBackToFrontPercent = 0;
    [Range(-1f, 1f)]
    public float m_moveLeftToRightPercent = 0;
    [Range(-1f, 1f)]
    public float m_moveDownToUpPercent = 0;



    [ContextMenu("Set random input")]
    public void SetRandomlyMyInput() { 
    
        m_rotateLeftRightPercent = Random.Range(-1f, 1f);
        m_moveBackToFrontPercent = Random.Range(-1f, 1f);
        m_moveLeftToRightPercent = Random.Range(-1f, 1f);
        m_moveDownToUpPercent = Random.Range(-1f, 1f);
    }



    private void Reset()
    {
        m_whatToMove = transform;

        float time = Time.deltaTime;
    }

    public Space m_typeOfSpaceMove = Space.Self;
    void Update()
    {
        m_whatToMove.Rotate(Vector3.up, 
            m_angleSpeedPerSecond 
            * Time.deltaTime
            * m_rotateLeftRightPercent
            , Space.Self);

        m_whatToMove.Translate(Vector3.forward *
            m_moveSpeedPerSecond *
            Time.deltaTime *
            m_moveBackToFrontPercent,
            m_typeOfSpaceMove);

        m_whatToMove.Translate(Vector3.right *
            m_moveSpeedPerSecond *
            Time.deltaTime *
            m_moveLeftToRightPercent,
            m_typeOfSpaceMove);
        m_whatToMove.Translate(Vector3.up *
            m_moveSpeedPerSecond *
            Time.deltaTime *
            m_moveDownToUpPercent,
            m_typeOfSpaceMove);
    }
}
