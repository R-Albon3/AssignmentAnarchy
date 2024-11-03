using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSpawn : MonoBehaviour
{

    public GameObject bossAssignment;
    public float bossTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossTime = bossTime + Time.deltaTime;
        if(bossTime >= 150){
            bossTime = -100;
            Instantiate(bossAssignment, transform.position, Quaternion.identity);
        }
    }
}
