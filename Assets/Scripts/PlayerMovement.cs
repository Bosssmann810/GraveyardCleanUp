using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public bool m_IsMoving = false;
    public Rigidbody2D rb;
    public Vector2 movement;
    void Start()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            m_IsMoving = true;
            movement = new Vector2(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y);
            rb.linearVelocity = movement * 5f ;
        }
        if (context.canceled)
        {
            m_IsMoving=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IsMoving== false)
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
