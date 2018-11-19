using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1HealthManager : MonoBehaviour {

	public GameObject[] livesP1; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (P1Movement.healthP1 == 2) {
			Destroy (livesP1 [2]);
		}
		else if (P1Movement.healthP1 == 1) {
		    Destroy (livesP1 [1]);
		}
		else if (P1Movement.healthP1 == 0) {
			Destroy (livesP1 [0]);
		}

	}
}
