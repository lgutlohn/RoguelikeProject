using UnityEngine;
using System.Collections;

public class bulletImpact : MonoBehaviour {
	public AudioClip impact;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter() {
		audio.PlayOneShot(impact, 1F);
	}
}
