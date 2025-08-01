using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 20;
    public float deadZone = -50;
   
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 

        if(transform.position.x < deadZone){
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
