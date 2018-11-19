using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombDrop : MonoBehaviour {

    [SerializeField]private GameObject bombPrefab;
	public AudioSource expEffect;
	private bool canDrop = true;


    public Tilemap tilemap1;

	// Update is called once per frame

	void Start(){
		ExpDamage.expSound = expEffect;
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && canDrop)
		{
			Vector3 posi = transform.position;
            Vector3Int cell = tilemap1.WorldToCell(posi);
            Vector3 cellCenter = tilemap1.GetCellCenterWorld(cell);
			//posi.x = Mathf.Round (posi.x);  
			//posi.y = Mathf.Round (posi.y);


			Instantiate(bombPrefab, cellCenter, Quaternion.identity); 
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
