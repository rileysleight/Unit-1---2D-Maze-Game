using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = 0;
        float yVelocity = 0;
        float speed = 5; 

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            xVelocity =-speed;
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
;
            xVelocity=speed;
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {

            yVelocity=speed;
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {

            yVelocity=-speed;
        }


        rb.velocity = new Vector2(xVelocity, yVelocity);
    }
}
