using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {

	public GameObject powerUp;
	public CannonControls Cannon;

	// Use this for initialization
	void Start () {
		Cannon = GameObject.Find ("Cannon").GetComponent<CannonControls>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Destroy (other.gameObject);
			Destroy(powerUp);
			Cannon.shotsLeft+=2;
		}
	}
}
