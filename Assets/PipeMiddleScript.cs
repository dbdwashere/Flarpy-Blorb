using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicalScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicalScript>();
    }

      
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        

    }
}
