using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScripts : MonoBehaviour {
    public GameObject play;
    public GameObject controls;
    public GameObject panelControls;
	// Use this for initialization
	void Start () {
        panelControls.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   public void openControls()
    {
        play.gameObject.SetActive(false);
        panelControls.gameObject.SetActive(true);
        controls.gameObject.SetActive(false);
    }
    public void closeControls()
    {
        play.gameObject.SetActive(true);
        panelControls.gameObject.SetActive(false);
        controls.gameObject.SetActive(true);
    }
    public void playGame()
    {
        Application.LoadLevel(0);
    }
}
