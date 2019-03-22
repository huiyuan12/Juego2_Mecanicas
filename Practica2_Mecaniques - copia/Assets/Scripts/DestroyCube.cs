using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour {
    public GameObject[] gb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gb = GameObject.FindGameObjectsWithTag("Spike");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {for (int i = 0; i < gb.Length; i++)
            {
                Destroy(gb[i]);
            }
            Destroy(this);
          
        }
    }
}
