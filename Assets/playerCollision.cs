using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    private playerHealth playerHealthScript;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        playerHealthScript = player.GetComponent<playerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Enemy")){
            Destroy(coll.gameObject);
            playerHealthScript.playerHearts = playerHealthScript.playerHearts - 1;
        } else if(collidedWith.CompareTag("Boss")){
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
            Destroy(gameObject);
        }
    }
}
