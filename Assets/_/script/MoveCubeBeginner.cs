using UnityEngine;

public class MoveCubeBeginner : MonoBehaviour
{
    public Transform m_whatToMove;
   
    public float m_moveForwardSpeed = 1.0f;
    public float m_moveBackwardSpeed = 0.2f;

    public float m_rotationDegreesPerSecond = 90.0f;

    [Range(-1.0f, 1.0f)]
    public float m_backwardForwardInputPercent = 0.0f;
    [Range(-1.0f, 1.0f)]
    public float m_leftRightInputPercent = 0.0f;

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

        Vector3 forwardBackwardMovement = m_whatToMove.forward * forwardBackwardSpeed * Time.deltaTime; 
        Vector3 currentPosition = m_whatToMove.position;
        Vector3 newPosition = currentPosition + forwardBackwardMovement;

        m_whatToMove.position = newPosition;


        float rotatePerFrame = m_rotationDegreesPerSecond * m_leftRightInputPercent * Time.deltaTime;
        m_whatToMove.Rotate(Vector3.up, rotatePerFrame);

    }
}
