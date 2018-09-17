using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{

		if (coll.gameObject.CompareTag("P1") && P1Movement.healthP1 < 3)
		{
			
			P1Movement.healthP1 = P1Movement.healthP1 + 1;
			Destroy(gameObject);
			Debug.Log("vida P1 = " + P1Movement.healthP1);
		}
		else{	Destroy(gameObject);	}

		if (coll.gameObject.CompareTag("P2") && P2Movement.healthP2 < 3)
		{
			
			P2Movement.healthP2 = P2Movement.healthP2 + 1;
			Destroy(gameObject);
			Debug.Log("vida P2 = " + P2Movement.healthP2);
		}
		else{	Destroy(gameObject);	}
	}
}
