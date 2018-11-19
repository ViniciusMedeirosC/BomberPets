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

		
		print("vida p2: " + P2LocalMove.healthP2);
if (P2LocalMove.healthP2 == 2) {
			//Destroy (livesP1 [2]);
			livesP2 [0].SetActive(false);
			livesP2 [1].SetActive(true);
			livesP2 [2].SetActive(true);
		}
		else if (P2LocalMove.healthP2 == 1) {
		   // Destroy (livesP1 [1]);
		    livesP2 [0].SetActive(false);
			livesP2 [1].SetActive(false);
			livesP2 [2].SetActive(true);
		}


		else if (P2LocalMove.healthP2 == 0) {
			//Destroy (livesP1 [0]);
			livesP2 [0].SetActive(false);
			livesP2 [1].SetActive(false);
			livesP2 [2].SetActive(false);
		}
        
        else if (P2LocalMove.healthP2 == 3) {
			//Destroy (livesP1 [0]);
			livesP2 [0].SetActive(true);
			livesP2 [1].SetActive(true);
			livesP2 [2].SetActive(true);
		}

		


	}
}
