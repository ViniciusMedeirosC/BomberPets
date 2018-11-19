using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2HealthManager : MonoBehaviour {

	public GameObject[] livesP2; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (P2Movement.healthP2 == 2) {
			Destroy (livesP2 [2]);
		}
		else if (P2Movement.healthP2 == 1) {
			Destroy (livesP2 [1]);
		}
		else if (P2Movement.healthP2 == 0) {
			Destroy (livesP2 [0]);
		}
		
	}
}
