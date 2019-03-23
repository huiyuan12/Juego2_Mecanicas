using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {
    public static bool isCollidingPlay;
    public SpriteRenderer sr;
	// Use this for initialization
	void Start () {
        sr.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
        sr.color = Color.white;
        if (isCollidingPlay)
        {
            sr.color = Color.red;
        }

        if (!isCollidingPlay)
        {
            sr.color = Color.white;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isCollidingPlay = false;
          
        }
    }
}
