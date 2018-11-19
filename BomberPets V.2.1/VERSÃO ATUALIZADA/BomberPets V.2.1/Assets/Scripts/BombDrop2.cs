using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop2 : MonoBehaviour {
	
	[SerializeField]private GameObject bombPrefab;


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightControl))
		{
			Vector2 posi = transform.position;
			Instantiate(bombPrefab, posi, Quaternion.identity); 
		}
	}
}
