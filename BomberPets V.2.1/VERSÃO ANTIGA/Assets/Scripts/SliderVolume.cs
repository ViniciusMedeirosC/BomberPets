using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour {


     public Slider volume;
     public string type;
	 //public AudioSource song;
	// Use this for initialization
	void Start () {
		
	}
	 
	// Update is called once per frame
	void Update () {
		if(type == "musica"){
         Institucional.musicM.volume = volume.value;
		}

		if(type == "efeitos"){
         ExpDamage.expSound.volume = volume.value;
		}
		

	}
}
