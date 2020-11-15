using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;

    private Transform target;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if(target.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if(target.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }
}
