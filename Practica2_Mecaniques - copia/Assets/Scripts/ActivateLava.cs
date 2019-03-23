using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLava : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Lava.isCollidingPlay = true;
        }
       
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Lava.isCollidingPlay = false;
        }
    }
}
