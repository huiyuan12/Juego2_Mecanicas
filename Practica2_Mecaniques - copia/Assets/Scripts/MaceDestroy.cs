using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceDestroy : MonoBehaviour {
    public static bool isPlayerColliding;
    public static bool wallColl;
    public GameObject wall;

    public GameObject[] walls;
	// Use this for initialization
	void Start () {
     
}
	
	// Update is called once per frame
	void Update () {
        walls = GameObject.FindGameObjectsWithTag("Wall");
        if (wallColl)
        {
            for (int i = 0; i < walls.Length; i++) {
                Destroy(walls[i]);
            }
            wallColl = false;
        }
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
           
            Debug.Log("Wall Coll");
        }
    }
}
