using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    //public AudioSource som;

	// Use this for initialization
	void Start () {
	
    }
	
	// Update is called once per frame
	void Update () {
      //  DontDestroyOnLoad(som);
	}

   public void Unmute()
    {
		Institucional.musicM.volume = 1f;
    }

    public void Mute()
    {
		Institucional.musicM.volume = 0f;

    }

    


}
