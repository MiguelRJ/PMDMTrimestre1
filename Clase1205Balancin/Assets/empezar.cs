﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empezar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
		}
	}
}
