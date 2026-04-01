using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    [SerializeField] private string m_message = "Comment ca va ?";
    [Tooltip("Number of frame since start of level")]
    /// <summary> Message for the developer. Frame Count since start of level. 
    /// Hey hey, this is a tooltip for the fame count variable.
    /// </summary>
    [SerializeField] private int m_fameCount = 0;

    void Start()
    {
        Debug.Log("Hello, World!"); 
        Debug.Log(m_message);

    }

    void Update()
    {
        m_fameCount = m_fameCount + 1;
    }
}
