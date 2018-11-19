using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour {

    public static int enemysQuant;
    

	// Use this for initialization
	void Start () {
        enemysQuant = 6;  
    }
	
	// Update is called once per frame
	void Update () {
        if (enemysQuant == 0)
        {
            SingleVictoryManager.victory = true;
        }
	}
}
