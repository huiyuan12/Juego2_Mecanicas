using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody2D rb;
    public static bool past;
    public static bool future;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        future = true;
        past = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
     
        rb.velocity = new Vector2(Time.deltaTime + 10, 0);
        if (future)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                    rb.position = new Vector2(rb.position.x - 5, 0.9495621f);
                    future = false;
                     past = true;
                Debug.Log("Future");
            }
        }
        if (past)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.position = new Vector2(rb.position.x + 5, 0.9495621f);
                future = true;
                past = false; Debug.Log("Past");
            }
        }

    }
}
