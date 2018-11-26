using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombDrop2 : MonoBehaviour {
	
	[SerializeField]private GameObject bombPrefab;
     private bool canDrop = true;

    public Tilemap tilemap2;



	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)&& canDrop)
		{
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap2.WorldToCell(posi);
            Vector3 cellCenter = tilemap2.GetCellCenterWorld(cell);
			Instantiate(bombPrefab, cellCenter, Quaternion.identity); 
			StartCoroutine("TimeToDrop");
		}
	}


	IEnumerator TimeToDrop ()
	{
	    canDrop = false;
		yield return new WaitForSeconds(0);
		canDrop = true;

	}
}
