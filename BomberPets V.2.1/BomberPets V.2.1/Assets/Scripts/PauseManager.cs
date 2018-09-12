﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour {

    public GameObject canvasPausa;

	// Use this for initialization
	void Start () {
        canvasPausa.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseScene()
    {
        Time.timeScale = 0f;
        canvasPausa.SetActive(true);
    }

    public void ResumeScene()
    {
        canvasPausa.SetActive(false);
        Time.timeScale = 1f;
    }
}