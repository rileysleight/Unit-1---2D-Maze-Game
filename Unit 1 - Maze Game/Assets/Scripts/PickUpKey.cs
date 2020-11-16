using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Key"))
        {
            gameObject.tag = "PlayerKey";
            Destroy(other.gameObject);
        }
    }
}

/* void on trigger
    {
        if (other tag is skeleton)
            {
                if (player tag = pplayer)
                {
                    destory player
                }
                if (player taG = PlayerSkull)
                {
                    destroy skeleton
                }
            }
    }
    */