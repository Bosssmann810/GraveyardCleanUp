using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public bool m_IsMoving = false;
    public Rigidbody2D rb;
    public Vector2 movement;
    public AudioSource playerAudio;
    public AudioClip walkingAudio;
    private bool isPlayingAudio;
    void Start()
    {
        
    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            StartAudio();
            m_IsMoving = true;
            movement = new Vector2(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y);
            rb.linearVelocity = movement * 5f ;
        }
        if (context.canceled)
        {
            isPlayingAudio = false;
            playerAudio.Stop();
            m_IsMoving=false;
        }
    }
    public void StartAudio()
    {
        if(isPlayingAudio == false)
        {
            isPlayingAudio = true;
            playerAudio.clip = walkingAudio;
            playerAudio.Play();
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
