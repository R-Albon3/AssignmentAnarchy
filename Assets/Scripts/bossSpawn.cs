using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSpawn : MonoBehaviour
{
    //Grabbing the boss prefab and setting time for boss spawn
    public GameObject bossAssignment;
    public float bossTime = 0.0f;
    
    void Update()
    {
        //Counts from the start of the game and spawns a boss once 150 seconds have passed
        bossTime = bossTime + Time.deltaTime;
        if(bossTime >= 150){
            //Setting bossTime to -100 to prevent it spawning more than one boss
            bossTime = -100;
            Instantiate(bossAssignment, transform.position, Quaternion.identity);
        }
    }
}
