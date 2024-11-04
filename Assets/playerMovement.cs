using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Setting public and private variables in relation to the player object components and speed
    public float playerSpeed;
    private float moveX, moveY;
    private Rigidbody2D playerBody;
    private SpriteRenderer playerSprite;
    public Animator animator;

    void Start()
    {
        //At start playerBody is assigned to the player object RigidBody component
        playerBody = GetComponent<Rigidbody2D>();
        //At start playerSprite is assigned to the player object child SpriteRenderer component
        playerSprite = GetComponentInChildren<SpriteRenderer>();

    }

    void Update()
    {
        //Movement inputs to determine which direction the player is attempting to move (1 for W D, -1 for A S, 0 for no movement)
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        //Sets the playerBody velocity equal to current movement directions multiplied by the set speed variable
        //Also uses normalize to prevent diagonal movement from being too fast
        playerBody.velocity = new Vector2(moveX, moveY).normalized * playerSpeed;
        //Setting animator playerSpeed to play correct animations
        animator.SetFloat("playerSpeed", Mathf.Abs(playerBody.velocity.magnitude));
        //If statement to flip the sprite depending on the current player direction
        if(moveX < 0){
            playerSprite.flipX = true;
        } else if (moveX > 0){
            playerSprite.flipX = false;
        }

    }
}
