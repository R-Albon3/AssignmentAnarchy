using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerProjectiles : MonoBehaviour
{
    //Setting general game objects for use later
    public GameObject pencilPrefab;
    public Transform playerPosition; 
    public Camera gameCamera;        
    //Setting attributes of the projectile
    public float fireRate = 1f;     
    public float projectileSpeed = 10f; 
    private float shotTimer = 0f; 

    public gameAudio gameAudio;

    void Start()
    {
        //Getting the audio source to play sound
        gameAudio = GameObject.FindGameObjectWithTag("Audio").GetComponent<gameAudio>(); 
    }

    void Update()
    {
        //Keeping track of time since last shot
        shotTimer = shotTimer + Time.deltaTime;

        //Fires a new projectile if enough time has elapsed
        if (shotTimer >= fireRate)
        {
            //Playing the shooting sfx
            gameAudio.PlaySFX(gameAudio.shootingPencil);
            //Create a projectile object from the pencil prefab and grab its corresponding Rigidbody2D to edit
            GameObject pencilProjectile = Instantiate(pencilPrefab, playerPosition.position, playerPosition.rotation);
            Rigidbody2D pencilRB = pencilProjectile.GetComponent<Rigidbody2D>();
            //Grab the cursorPosition relative to the game, set z = 0 to keep projectiles from slowing based on the cursors position to the player
            Vector3 cursorPosition = gameCamera.ScreenToWorldPoint(Input.mousePosition);
            cursorPosition.z = 0;
           //Set the projectileDirection to the position of the cursor relative to the players position and normalize for speed
            Vector2 projectileDirection = (cursorPosition - playerPosition.position).normalized;
            //Set the velocity = set speed * the projectileDirection
            pencilRB.velocity = projectileDirection * projectileSpeed;

            //Correcting the angle of the projectile so that it points in the correct direction when fired
            float projectileAngle = (Mathf.Atan2(projectileDirection.y, projectileDirection.x) * Mathf.Rad2Deg) - 90;
            pencilProjectile.transform.rotation = Quaternion.Euler(new Vector3(0, 0, projectileAngle));

            //Reset the clock to time the next shot
            shotTimer = 0f; 
            //Destroy the projectile after the set time
            Destroy(pencilProjectile, 5);


            
        }
    }
}