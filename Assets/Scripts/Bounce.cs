using UnityEngine; 
using System.Collections;

public class Bounce : MonoBehaviour {

	// Use this for initialization 
	void Start () {
		rigidbody.velocity = Vector3.right;
	}

	// Update is called once per frame 
	void Update () {
		rigidbody.velocity = rigidbody.velocity.normalized;
	}

	void OnCollisionEnter(Collision collision) {
		// Invert the velocity
		rigidbody.velocity = rigidbody.velocity * -1.0f;
	}
}