using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour {

	public float boostPower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		other.rigidbody.MoveRotation(transform.rotation);
		other.rigidbody.velocity = transform.forward * (other.rigidbody.velocity.magnitude + boostPower);
	}
}
