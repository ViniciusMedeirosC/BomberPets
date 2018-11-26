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

	void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.gameObject.CompareTag("P1"))
		{
			Debug.Log("mais rapido");
			P1LocalMove.speedP1 = P1LocalMove.speedP1 + 1.5f;
			Destroy(gameObject);
		}

		if (coll.gameObject.CompareTag("P2"))
		{
			Debug.Log("mais rapido");
			P2LocalMove.speedP2 = P2LocalMove.speedP2 + 1.5f;
			Destroy(gameObject);
		}
	} 
}
