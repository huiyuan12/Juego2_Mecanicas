using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseUI3 : MonoBehaviour {

    public bool isCol;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isCol)
        {
            TimeUI.trys++;
            isCol = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isCol = true;
        }
    }
}
