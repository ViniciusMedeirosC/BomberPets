using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Institucional : MonoBehaviour {
	
	public AudioSource musicMenu;
	public static AudioSource musicM;


	// Use this for initialization
	void Start () {
		StartCoroutine ("InstitucionalTime");
		musicM = musicMenu;
	}

	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (musicM);
	}

	IEnumerator InstitucionalTime()
	{
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene ("Menu");

	}
}
