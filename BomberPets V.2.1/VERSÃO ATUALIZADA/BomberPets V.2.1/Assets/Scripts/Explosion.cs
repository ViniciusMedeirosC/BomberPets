﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public GameObject expPrefab;

	void OnDestroy()
	{
        Instantiate(expPrefab, transform.position, Quaternion.identity);
	}
}
