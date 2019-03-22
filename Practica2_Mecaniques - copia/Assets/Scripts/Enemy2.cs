using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
    public Rigidbody2D rb;
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
            Instantiate(rb, new Vector3(60, 0, -6), Quaternion.identity);
            Instantiate(rb, new Vector3(75, 0, -6), Quaternion.identity);
            Instantiate(rb, new Vector3(90, 0, -6), Quaternion.identity);
            Instantiate(rb, new Vector3(105, 0, -6), Quaternion.identity);
            Destroy(gameObject);
        }
      
    }
}
