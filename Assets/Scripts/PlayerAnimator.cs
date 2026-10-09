using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] Animator playerAnimator;
    private GameObject player;
    [SerializeField] PlayerLook playerLook;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] PlayerShoot playerShoot;

    int isMovingHash = Animator.StringToHash("isMoving");
    int isShootingHash = Animator.StringToHash("isShooting");
    int isLeftHash = Animator.StringToHash("isLeft");

    public bool isMoving;
    public bool isShooting;
    public bool isLeft;

    void Start()
    {
        player = this.gameObject;
        playerMovement = player.GetComponent<PlayerMovement>();
        playerLook = player.GetComponent<PlayerLook>();
        playerShoot = player.GetComponent<PlayerShoot>();
        isMoving = playerMovement.m_IsMoving;
    }

    void UpdateValues()
    {
        if (playerMovement.m_IsMoving == true)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
    }

    void AnimationMovement()
    {
        if (isMoving == true)
        {
            playerAnimator.SetBool(isMovingHash, true);
        }
        else
        {
            playerAnimator.SetBool(isMovingHash, false);
        }
    }

    private void Update()
    {
        UpdateValues();
        AnimationMovement();
    }
}
