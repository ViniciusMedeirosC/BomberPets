using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpeed : MonoBehaviour {
 
      

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	  
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.CompareTag("P1"))
		{
			Debug.Log("mais rapido");
			P1Movement.speedP1 = P1Movement.speedP1 + 10;
			Destroy(gameObject);
		}

		if (coll.gameObject.CompareTag("P2"))
		{
			Debug.Log("mais rapido");
			P2Movement.speedP2 = P2Movement.speedP2 + 10;
			Destroy(gameObject);
		}
	} 
}
