using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{

    //Get access to playerHealthScript to adjust remaining hearts
    private playerHealth playerHealthScript;
    public GameObject player;
    
    void Start()
    {
        //Getting the playerHealth
        playerHealthScript = player.GetComponent<playerHealth>();
    }
    //Collision for the player destroying the enemy if collided with and ending the game if hit by boss (loads loss screen)
    void OnCollisionEnter2D(Collision2D coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Enemy")){
            Destroy(coll.gameObject);
            playerHealthScript.playerHearts = playerHealthScript.playerHearts - 1;
        } else if(collidedWith.CompareTag("Boss")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
