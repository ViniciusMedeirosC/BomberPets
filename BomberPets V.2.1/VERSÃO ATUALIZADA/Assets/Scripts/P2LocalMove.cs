using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class P2LocalMove : MonoBehaviour {

	// Use this for initialization
	 private Rigidbody2D rb;
    public static float speedP2;
	public static int healthP2;
	public Tilemap tilemap3;
	private bool canHit;

	void Start () {
		canHit = true;
		rb = GetComponent <Rigidbody2D>(); 
		healthP2 = 3;
		speedP2 = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (healthP2 <= 0) {
			Destroy (gameObject);
		}

        
	}

	void FixedUpdate()
	{
       // rb.velocity = new Vector2(Input.GetAxis("HorizontalP2") * speedP2, Input.GetAxis("VerticalP2") * speedP2);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap3.WorldToCell(posi);
			Vector3 cellCenter = tilemap3.GetCellCenterWorld(cell);
			transform.position = cellCenter;
            rb.velocity = new Vector2(-speedP2, 0);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap3.WorldToCell(posi);
			Vector3 cellCenter = tilemap3.GetCellCenterWorld(cell);
			transform.position = cellCenter;
            rb.velocity = new Vector2(speedP2, 0);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap3.WorldToCell(posi);
			Vector3 cellCenter = tilemap3.GetCellCenterWorld(cell);
			transform.position = cellCenter;
            rb.velocity = new Vector2(0, speedP2);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
			Vector2 posi = transform.position;
			Vector3Int cell = tilemap3.WorldToCell(posi);
			Vector3 cellCenter = tilemap3.GetCellCenterWorld(cell);
			transform.position = cellCenter;
            rb.velocity = new Vector2(0, - speedP2);
        }


//       if(rb.velocity == 0)
//       {
//          float x = Mathf.Round(transform.position.x);
//            float y = Mathf.Round(transform.position.y);
//
//
//        }



	//	rb.velocity = new Vector2(Input.GetAxisRaw("HorizontalP2") * speedP2, Input.GetAxisRaw("VerticalP2") * speedP2);   

//		if (rb.velocity.x == 0 && rb.velocity.y == 0) {
//		
//			Vector3 posi = rb.position;
//			Vector3Int cell = tilemap3.WorldToCell(posi);
//			cell = posi;
//		    
//
//		}
    }

    void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag("Explosion") && canHit)
		{
			
			healthP2 = healthP2 - ExpDamage.damage;
			StartCoroutine ("TimeToNextHit");
			Debug.Log (healthP2 + " p2");
		}
	}

	IEnumerator TimeToNextHit()
	{

		canHit = false; 
		yield return new WaitForSeconds(2);
		canHit = true;

	}
}
