using UnityEngine;
using System.Collections;

public class CarControls : MonoBehaviour {
	
	public float turnSpeed = 10f;
	public float forwardSpeed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	void FixedUpdate(){
		
		if(Input.GetKey(KeyCode.W)){
			rigidbody.AddRelativeForce(Vector3.back* forwardSpeed);
			

		}
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0f,-5f*turnSpeed,0f);
		}
				
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0f,5f*turnSpeed,0f);
		}
					
		if(Input.GetKey(KeyCode.S)){
			rigidbody.AddRelativeForce(Vector3.forward* forwardSpeed);
		}
	}
}
