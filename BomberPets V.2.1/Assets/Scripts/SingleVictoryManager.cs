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
        canvasVictory.SetActive(false);
        canvasDefeat.SetActive(false);
        victory = false;
        defeat = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (victory)
        {
            //canvasVictory.SetActive(true);
            Debug.Log("vitoriaaa");
        }
        else if (defeat)
        {
            //canvasDefeat.SetActive(true);
        }
	}
}
