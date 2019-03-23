using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeUI : MonoBehaviour {
    public Text timeUI;
    public Text intentos;
    public static int trys;
	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Movement.future)
        {
            timeUI.text = "FUTURE";
        }
        if (Movement.past)
        {
            timeUI.text = "PAST";
        }
        intentos.text = "ATTEMPTS: " + trys.ToString();
    }

}
