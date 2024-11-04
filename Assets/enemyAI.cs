using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{

    private  GameObject player;
    
    public float enemySpeed = 2f;
    private float distanceToPlayer;

    public gameAudio gameAudio;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindWithTag("Player");
        gameAudio = GameObject.FindGameObjectWithTag("Audio").GetComponent<gameAudio>();
    

    }

    // Update is called once per frame
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
