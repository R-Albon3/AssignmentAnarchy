using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossScript : MonoBehaviour
{
    //Creating objects to grab their respective components and setting relevant variables
    private  GameObject player;
    public float enemySpeed = 2f;
    private float distanceToPlayer;
    public float bossHealth = 5;
    public gameAudio gameAudio;
    public bossHealthBar healthBar;
    
    void Start()
    {
        //Setting respective objects by finding tags
        player = GameObject.FindWithTag("Player");
        gameAudio = GameObject.FindGameObjectWithTag("Audio").GetComponent<gameAudio>();
        healthBar = GetComponentInChildren<bossHealthBar>();
    }

    void Update()
    {
        //Similar to the regular enemy AI calculates movement to follow the player
        distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);
        Vector2 directionToPlayer = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, enemySpeed * Time.deltaTime);
        //If the boss health gets to 0 then show victory scene
        if(bossHealth <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
    //Collision function
    void OnCollisionEnter2D(Collision2D coll){
        GameObject collidedWith = coll.gameObject;
        //If the boss collides with a pencil set its health to health - 1 and update the UI elements
        if(collidedWith.CompareTag("Pencil")){
            bossHealth = bossHealth - 1;
            healthBar.UpdateHealthBar();
            gameAudio.PlaySFX(gameAudio.paperTear);
        }
    }
}