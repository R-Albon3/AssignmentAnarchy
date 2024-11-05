using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{

    //Same structure as the bossAI file with the exception of additional player collision which would also destroy the enemy
    private  GameObject player;
    public float enemySpeed = 2f;
    private float distanceToPlayer;
    public gameAudio gameAudio;
    
    void Start()
    {
        
        player = GameObject.FindWithTag("Player");
        gameAudio = GameObject.FindGameObjectWithTag("Audio").GetComponent<gameAudio>();
    

    }

    void Update()
    {
        distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);
        Vector2 directionToPlayer = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, enemySpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Pencil")){
            gameAudio.PlaySFX(gameAudio.paperTear);
            Destroy(gameObject);
        } else if (collidedWith.CompareTag("Player")){
            gameAudio.PlaySFX(gameAudio.paperTear);
            Destroy(gameObject);
        }
    }
}
