using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 26;
    private float timer = 0;
    public float heightOffset = 2;
   
    void Start()
    {
        SpawnPipe();
    }

    void Update(){
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        }

        else{
            SpawnPipe();
            timer = 0;
        }
       
    }

    void SpawnPipe(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

}
