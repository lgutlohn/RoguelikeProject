using UnityEngine;
using System.Collections;

public class startSound : MonoBehaviour {

	public AudioClip levelLoad;

	// Use this for initialization
	void Start () {
		audio.PlayOneShot (levelLoad, .5f);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
