using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop : MonoBehaviour {

    [SerializeField]private GameObject bombPrefab;
	public AudioSource expEffect;
	private bool canDrop = true;

	// Update is called once per frame

	void Start(){
		ExpDamage.expSound = expEffect;
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && canDrop)
		{
			Vector2 posi = transform.position;
			posi.x = Mathf.Round (posi.x);
			posi.y = Mathf.Round (posi.y);
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
