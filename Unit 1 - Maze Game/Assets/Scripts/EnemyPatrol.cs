﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;

    public bool  MoveRight;

    void Start()
    {
        
    }


    void Update()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed , 0,0);
            transform.localScale= new Vector2 (-2,2);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed , 0,0);
            transform.localScale= new Vector2 (2,2);
        }

    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
        
    }
}
