using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    //Creating a gameobject for the assignment prefab and setting timers for relevant enemy spawning
    public GameObject enemyAssignment;
    public float minimumSpawn = 10.0f;
    public float maximumSpawn = 11.0f;
    private float timeTillSpawn;
    private float currentTime = 0.0f;
    
    void Start()
    {
        //Sets timeTillSpawn = 0 to instantly spawn one wave
        timeTillSpawn = 0;
    }

    void Update()
    {
        //Calculting current tillspawn and time variables 
        timeTillSpawn = timeTillSpawn - Time.deltaTime;
        currentTime = currentTime + Time.deltaTime;
        //If statement to spawn a new wave and determine the next spawn time within the ranges
        if(timeTillSpawn <= 0){
            Instantiate(enemyAssignment, transform.position, Quaternion.identity);
            timeTillSpawn = Random.Range(minimumSpawn, maximumSpawn);
        }

        //Every 30 seconds (after each upgrade) increase the rate at which waves can spawn
        if(currentTime >= 30){
            currentTime = 0;
            if(minimumSpawn > 1){
                minimumSpawn = minimumSpawn - 1;
                maximumSpawn = maximumSpawn - 1;
            }
        }
    }
}
