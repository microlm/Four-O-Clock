﻿using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadLevel()
	{
		Application.LoadLevel(level);
	}
}
