﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "mace")
        {
            MaceDestroy.wallColl = true;
        }
    }
}