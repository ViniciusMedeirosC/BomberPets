using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed;

	void Start () {
		InvokeRepeating("Changendir" , 0 , 0.5f);		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Explosion"))
        {
            Destroy(gameObject);
            EnemyCounter.enemysQuant = EnemyCounter.enemysQuant - 1;
            Debug.Log(EnemyCounter.enemysQuant);
        }

    }

    Vector2 Randir () {

		int r = Random.Range (-1, 2);

		return (Random.value < 0.5) ? new Vector2(r,0) : new Vector2 (0,r);
	}


	private bool Isvalid(Vector2 dir){
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast (pos + dir, pos);
		return ( hit.collider.gameObject == gameObject);




	}	
	public void Changendir() {
		Vector2 dir = Randir ();
		if (Isvalid(dir))
		{
			GetComponent<Rigidbody2D>().velocity = dir * speed;
			GetComponent<Animator>().SetInteger ("x", (int) dir.x);
			GetComponent<Animator>().SetInteger ("y", (int) dir.y);
		}
		              


	}

}
