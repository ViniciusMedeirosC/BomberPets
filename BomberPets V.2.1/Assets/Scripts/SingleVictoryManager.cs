using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleVictoryManager : MonoBehaviour {

    public static bool victory;
    public static bool defeat;
    public GameObject canvasVictory;
    public GameObject canvasDefeat;

    // Use this for initialization
    void Start ()
    {
        victory = false;
        defeat = false;
        canvasVictory.SetActive(false);
        canvasDefeat.SetActive(false);
        Debug.Log("desativa etc");
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (victory == true)
        {
            canvasVictory.SetActive(true);
        }
        if (defeat == true)
        {
            canvasDefeat.SetActive(true);
        }

        
	}
}
