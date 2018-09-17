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
			//Destroy (livesP1 [2]);
			livesP1 [2].SetActive(false);
			livesP1 [1].SetActive(true);
			livesP1 [0].SetActive(true);
		}
		else if (P1Movement.healthP1 == 1) {
		   // Destroy (livesP1 [1]);
		    livesP1 [2].SetActive(false);
			livesP1 [1].SetActive(false);
			livesP1 [0].SetActive(true);
		}


		else if (P1Movement.healthP1 == 0) {
			//Destroy (livesP1 [0]);
			livesP1 [2].SetActive(false);
			livesP1 [1].SetActive(false);
			livesP1 [0].SetActive(false);
		}
        
        else if (P1Movement.healthP1 == 3) {
			//Destroy (livesP1 [0]);
			livesP1 [2].SetActive(true);
			livesP1 [1].SetActive(true);
			livesP1 [0].SetActive(true);
		}

	



//programação P2 


	}
}
