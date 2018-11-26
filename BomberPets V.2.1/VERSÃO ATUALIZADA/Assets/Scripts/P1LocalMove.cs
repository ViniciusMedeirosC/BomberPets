using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class P1LocalMove : MonoBehaviour {

    private Rigidbody2D rb;
    
	public static float speedP1;
	public static int healthP1;
	public Tilemap tilemap4;
	private bool canHit;


	// Use this for initialization
	void Start () {
		canHit = true;
		rb = GetComponent <Rigidbody2D>(); 
		healthP1 = 3;
        Time.timeScale = 1f;
		speedP1 = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (healthP1 <= 0) {
			Destroy (gameObject);
            SingleVictoryManager.defeat = true;
		}
	}

	void FixedUpdate()
    {



		if (Input.GetKeyDown(KeyCode.A))
		{
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap4.WorldToCell(posi);
			Vector3 cellCenter = tilemap4.GetCellCenterWorld(cell);
			transform.position = cellCenter;
			rb.velocity = new Vector2(-speedP1, 0);
		}

		else if (Input.GetKeyDown(KeyCode.D))
		{
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap4.WorldToCell(posi);
			Vector3 cellCenter = tilemap4.GetCellCenterWorld(cell);
			transform.position = cellCenter;
			rb.velocity = new Vector2(speedP1, 0);
		}

		else if (Input.GetKeyDown(KeyCode.W))
		{
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap4.WorldToCell(posi);
			Vector3 cellCenter = tilemap4.GetCellCenterWorld(cell);
			transform.position = cellCenter;
			rb.velocity = new Vector2(0, speedP1);
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap4.WorldToCell(posi);
			Vector3 cellCenter = tilemap4.GetCellCenterWorld(cell);
			transform.position = cellCenter;
			rb.velocity = new Vector2(0, - speedP1);
		}




    // rb.velocity = new Vector2(Input.GetAxis("HorizontalP1") * speedP1, Input.GetAxis("VerticalP1") * speedP1);   
        
    }


	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag("Explosion") && canHit)
		{
			healthP1 = healthP1 - ExpDamage.damage;
			StartCoroutine ("TimeToNextHit");
			Debug.Log (healthP1  + " p1");
		}
			
       
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            healthP1 = healthP1 - 1;

        }
    }

	IEnumerator TimeToNextHit()
	{
		canHit = false; 
		yield return new WaitForSeconds(2);
		canHit = true;
	}
}
