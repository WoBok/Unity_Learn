using UnityEngine;

public class InputSystem : MonoBehaviour
{
    InputActions m_InputAction;
    void Start()
    {
        m_InputAction = new InputActions();
        m_InputAction.Map1.A.performed += ctx =>
        {
            Debug.Log("Map1.A");
        };
        m_InputAction.Map2.A.performed += ctx =>
        {
            Debug.Log("Map2.A");
        };
        m_InputAction.Enable();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            m_InputAction.Map2.Disable();
        }
    }
}