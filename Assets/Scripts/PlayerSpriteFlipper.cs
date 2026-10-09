using UnityEngine;

public class PlayerSpriteFlipper : MonoBehaviour
{
    public SpriteRenderer player;
    public PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FlipSprite();
    }

    public void FlipSprite()
    {
        if (playerMovement.movement.x > 0)
        {
            player.flipX = false;
        }
        if(playerMovement.movement.x < 0)
        {
            player.flipX = true;
        }
    }
}
