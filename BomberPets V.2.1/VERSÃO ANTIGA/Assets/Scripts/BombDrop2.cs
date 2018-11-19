using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop2 : MonoBehaviour {
	
	[SerializeField]private GameObject bombPrefab;
     private bool canDrop = true;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightControl)&& canDrop)
		{
			Vector2 posi = transform.position;
			Instantiate(bombPrefab, posi, Quaternion.identity); 
			StartCoroutine("TimeToDrop");
		}
	}


	IEnumerator TimeToDrop ()
	{
	    canDrop = false;
		yield return new WaitForSeconds(3);
		canDrop = true;

	}
}
