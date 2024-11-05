using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pencilCollision : MonoBehaviour
{
    //Collision function which destroys the pencil if it hits one of the corresponding targets
    void OnCollisionEnter2D(Collision2D coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Enemy")){
            Destroy(gameObject);
        } else if(collidedWith.CompareTag("Boss")){
            Destroy(gameObject);
        }
    }
}
