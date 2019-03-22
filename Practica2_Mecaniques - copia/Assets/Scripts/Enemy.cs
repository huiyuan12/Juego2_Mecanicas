using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Rigidbody2D rb;
    public bool isColliding;
    public bool firstTime;
	// Use this for initialization
	void Start () {
        isColliding = false;
        rb.transform.position = new Vector3(27.23f, 5,-5);
    }
	
	// Update is called once per frame
	void Update () {

        if (isColliding)
        {
            rb.gravityScale = 6;
            if (Input.GetKey(KeyCode.W))
            {
                rb.gravityScale = 0;
                rb.transform.position = new Vector3(27.23f, 2f, -5);

            }
            if (Input.GetKey(KeyCode.Q))
            {
                rb.transform.position = new Vector3(27.23f, 5, -5);
                rb.gravityScale = 6;
              
            }
        }
        else
        {
            rb.gravityScale = 0;
        }
   

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isColliding = true;
        }
       
    }
}
