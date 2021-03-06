﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldiers_Spawner : MonoBehaviour {
	public Soldiers		soldier;
	private float 		elapsed;
	private bool 		firstTime;

	// Use this for initialization
	void Start () {
		elapsed = 0f;
		firstTime = true;
	}
	// Update is called once per frame
	void Update () {
		if (firstTime)
		{
			GameObject.Instantiate(soldier);
			firstTime = false;
		}
		elapsed += Time.deltaTime;
		if (elapsed >= 10f)
		{
        	elapsed = elapsed % 10f;
			GameObject.Instantiate(soldier);
		}
	}
}
