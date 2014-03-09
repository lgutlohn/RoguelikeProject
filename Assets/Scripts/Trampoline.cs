using UnityEngine;
using System.Collections;


public class Trampoline : MonoBehaviour {

	public float bounceAmount = 10;
	public bool bounce = false;
	public Transform Player; 
	
	void Start () {

	}

	// Update is called once per frame
	void Update () {	

		if(bounce) {
			//Player.rigidbody.velocity.y = 0;
			Player.rigidbody.velocity += new Vector3(1, 0, 1);
			Player.rigidbody.AddForce(0,bounceAmount,0,ForceMode.Impulse);
			bounce = false;
		}

	}

	void OnCollisionEnter (Collision other) {
		
		if(other.gameObject.name == "Player") {
			bounce = true;
		}
		
	}
	
}