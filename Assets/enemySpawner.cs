using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyAssignment;
    public float minimumSpawn = 10.0f;
    public float maximumSpawn = 11.0f;
    private float timeTillSpawn;
    private float currentTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        timeTillSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeTillSpawn = timeTillSpawn - Time.deltaTime;
        currentTime = currentTime + Time.deltaTime;

        if(timeTillSpawn <= 0){
            Instantiate(enemyAssignment, transform.position, Quaternion.identity);
            timeTillSpawn = Random.Range(minimumSpawn, maximumSpawn);
        }


        if(currentTime >= 30){
            currentTime = 0;
            if(minimumSpawn > 1){
                minimumSpawn = minimumSpawn - 1;
                maximumSpawn = maximumSpawn - 1;
            }
        }
    }
}
