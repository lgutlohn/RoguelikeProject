using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

	public float rotationSpeed;


	// Use this for initialization
	void Start () {
		rotationSpeed = Random.Range(.5f, 1.75f);
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.down*rotationSpeed);
	}
}
