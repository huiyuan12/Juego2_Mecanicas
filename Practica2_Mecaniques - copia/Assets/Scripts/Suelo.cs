using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {
    public GameObject suelo;
    public bool isCollided;
    public float timeDestroy;
    public float counter;
	// Use this for initialization
	void Start () {
        suelo.gameObject.SetActive(false); counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (isCollided)
        {
          
            suelo.gameObject.SetActive(true);
            if (counter >= 50f)
            {
                suelo.gameObject.SetActive(false);
            }
            else
            {
                counter++;
            }
        }
       
      
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isCollided = true;
        }
    }
}
