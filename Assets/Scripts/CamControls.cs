using UnityEngine;
using System.Collections;

public class CamControls : MonoBehaviour {
	
	public float turnSpeed = 10f;
	public float forwardSpeed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	void FixedUpdate(){
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (Vector3.left* forwardSpeed);
			

		}
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate (Vector3.up* forwardSpeed);
		}
				
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate (Vector3.down* forwardSpeed);
		}
					
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate (Vector3.right * forwardSpeed);
		}
		
		if(Input.GetKey(KeyCode.Comma)){
			transform.Translate (Vector3.back* forwardSpeed);
		}
		
		if(Input.GetKey(KeyCode.Period)){
			transform.Translate (Vector3.forward* forwardSpeed);
		}


	}
}
