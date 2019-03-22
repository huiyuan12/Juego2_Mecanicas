using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour {
    public GameObject wall;
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
            Instantiate(wall,new Vector3(117.5538f, 3.365721f,0),Quaternion.identity);
            MaceDestroy.isPlayerColliding = true;
        }
    }
}
