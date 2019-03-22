using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpike : MonoBehaviour {
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3(-5, 0, -6);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.position = new Vector2(rb.position.x + 5, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.position = new Vector2(rb.position.x - 5, 0);
        }
    }
}
