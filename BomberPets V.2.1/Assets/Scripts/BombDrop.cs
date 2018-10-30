using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop : MonoBehaviour {

    [SerializeField]private GameObject bombPrefab;
	public AudioSource lalala;
	private bool canDrop = true;

	// Update is called once per frame

	void Start(){
		ExpDamage.expSound = lalala;
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && canDrop)
		{
			Vector2 posi = transform.position;
			Instantiate(bombPrefab, posi, Quaternion.identity); 
		}
		
	}

	IEnumerator TimeToDrop ()
	{
	    canDrop = false;
		yield return new WaitForSeconds(3);
		canDrop = true;

	}
}
