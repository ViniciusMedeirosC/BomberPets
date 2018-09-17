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
			Debug.Log("vida P1 = " + P1Movement.healthP1);
			P1Movement.healthP1 = P1Movement.healthP1 + 1;
			Destroy(gameObject);
		}
		else{	Destroy(gameObject);	}
	}
}
