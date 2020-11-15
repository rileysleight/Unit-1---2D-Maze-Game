using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LadyScript : MonoBehaviour
{
    public int Respawn;
    public Text win;
    // Start is called before the first frame update
    void Start()
    {
        //win.text = " "; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("PlayerKey"))
        {
            win.text = "CONGRATULATIONS, YOU WON!!";
            
        }
    }
}
