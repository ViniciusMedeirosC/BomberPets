﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour {

	public float timeToDestroy = 3;

	void Start () {
		Destroy(gameObject, timeToDestroy);
	}
	

}
