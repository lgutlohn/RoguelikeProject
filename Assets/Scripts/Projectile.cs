﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public float projectileSpeed = 1f;
	public float projectileRange = 500f;
	float projectileDistance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		projectileDistance += Time.deltaTime * projectileSpeed;
		if(projectileDistance >= projectileRange){
			GameObject.Destroy(this.gameObject);
		}
	}
}
