﻿using UnityEngine;
using System.Collections;

public class SlowMotion : MonoBehaviour {

	public GameObject sphere;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		if(other.gameObject){
			if(sphere){
				//Instantiate(sphere, (transform.position), transform.rotation);
				Time.timeScale = 0.3f;	
			}		
		}
	}
}
