using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryPanel : MonoBehaviour {

	public GameObject p1Victory;
	public GameObject p2Victory;
	public GameObject menuButton;

	// Use this for initialization
	void Start () {
		p1Victory.SetActive (false);
		p2Victory.SetActive (false);
		menuButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (P1Movement.healthP1 <= 0) {
			//Time.timeScale = 0f;
			p2Victory.SetActive (true);
			menuButton.SetActive (true);
		}
		else if (P2Movement.healthP2 <= 0) {
		    //Time.timeScale = 0f;
			p1Victory.SetActive (true);
			menuButton.SetActive (true);
		}
	}
}
