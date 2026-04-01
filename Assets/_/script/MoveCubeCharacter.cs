using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveCubeCharacter : MonoBehaviour
{
    public CharacterController m_whatToMove;
   
    public float m_moveForwardSpeed = 1.0f;
    public float m_moveBackwardSpeed = 0.2f;

    public float m_rotationDegreesPerSecond = 90.0f;

    [Range(-1.0f, 1.0f)]
    public float m_backwardForwardInputPercent = 0.0f;
    [Range(-1.0f, 1.0f)]
    public float m_leftRightInputPercent = 0.0f;


    public void setAsTurningLleft(bool isTurningLeft)
    {
        if (isTurningLeft)
        {
            m_leftRightInputPercent = -1.0f;
        }
        else
        {
            m_leftRightInputPercent = 0.0f;
        }
    }
    public void setAsTurningRight(bool isTurningRight)
    {
        if (isTurningRight)
        {
            m_leftRightInputPercent = 1.0f;
        }
        else
        {
            m_leftRightInputPercent = 0.0f;
        }
    }

    public void setAsMovingForward(bool isMovingForward)
    {
        if (isMovingForward)
        {
            m_backwardForwardInputPercent = 1.0f;
        }
        else
        {
            m_backwardForwardInputPercent = 0.0f;
        }
    }

    public void setAsMovingBackward(bool isMovingBackward)
    {
        if (isMovingBackward)
        {
            m_backwardForwardInputPercent = -1.0f;
        }
        else
        {
            m_backwardForwardInputPercent = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {

        float forwardBackwardSpeed = 0.0f;
        if (m_backwardForwardInputPercent > 0.0f)
        {
            forwardBackwardSpeed = m_moveForwardSpeed * m_backwardForwardInputPercent;
        }
        else
        {
            forwardBackwardSpeed = m_moveBackwardSpeed * m_backwardForwardInputPercent;
        }
        forwardBackwardSpeed = forwardBackwardSpeed * Time.deltaTime;

        Vector3 moveDirection = m_whatToMove.transform.forward *forwardBackwardSpeed;
        moveDirection.y = 0.0f; // don't move up or down
        m_whatToMove.Move(moveDirection);


        float rotatePerFrame = m_rotationDegreesPerSecond * m_leftRightInputPercent * Time.deltaTime;
        m_whatToMove.transform.Rotate(Vector3.up, rotatePerFrame);

    }
}
