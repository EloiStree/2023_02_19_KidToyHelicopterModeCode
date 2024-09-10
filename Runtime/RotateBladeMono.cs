using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBladeMono : MonoBehaviour
{
    public Transform m_toRotate;
    public float m_angleSpeed = 90;
    public Vector3 m_axisRotation= Vector3.up;
    public Space m_typeOfRotation = Space.Self;
    void Update()
    {
        m_toRotate.Rotate(m_axisRotation, m_angleSpeed *Time.deltaTime, m_typeOfRotation);
    }
}
