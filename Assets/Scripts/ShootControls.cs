using UnityEngine;
using System;

public class ShootControls : MonoBehaviour {

	// Use this for initialization
	public float rotChange;
	public float velChange;
	float shotVelocity = 0;
	public Transform pointer;
	public GUIText rotText;
	public GUIText velText;
	bool powerSelect = false;
	Vector3 startPosition;
	void Start () {
		startPosition = rigidbody.position;
	}
	
	// Update is called once per frame
	void Update () {



	
	}

	void FixedUpdate(){

		//Controls at Firing Position
		if (rigidbody.position == startPosition) {

			//Rotation Control

			Vector3 rotVector = new Vector3 (0, rotChange*Input.GetAxis("Horizontal"), 0);
			
			Quaternion deltaRotation = Quaternion.Euler(rotVector * Time.deltaTime);
			rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);

			pointer.rotation = rigidbody.rotation;

			// Axis Velocity Control
			
			shotVelocity += Input.GetAxis ("Vertical") * velChange;

			if (Input.GetKey(KeyCode.LeftControl)){
				rigidbody.AddForce(transform.forward*shotVelocity);
			}

			//Charge Velocity Control
//				if (Input.GetKey(KeyCode.Space)){
//					shotVelocity += velChange;
//				}
//				if (Input.GetKeyUp(KeyCode.Space)){
//					rigidbody.AddForce(transform.forward*shotVelocity);
//				}
			//Timing Velocity Control
//			if(Input.GetKeyUp(KeyCode.RightControl)){
//				powerSelect=true;
//			}
//			if (powerSelect){
//				shotVelocity += velChange/10;
//				if (Math.Abs(shotVelocity)>1000){
//					velChange *= -1;
//				}
//				if(Input.GetKeyDown(KeyCode.RightControl)&&shotVelocity !=0){
//					rigidbody.AddForce(transform.forward*shotVelocity);
//				}
//			}
			//GUI
			string rotString = rigidbody.rotation.eulerAngles.y.ToString();
			
			rotText.text = "Rotation: " + rotString;
			if ((rotString.IndexOf(".") > -1) && (rotString.Length>rotString.IndexOf(".")+ 4)){
				rotText.text = "Rotation: " + rotString.Substring(0, rotString.IndexOf(".") ) + rotString.Substring(rotString.IndexOf("."), 3);
			}
			
			
			string velString = shotVelocity.ToString();
			velText.text = "Velocity : " + velString;
			if ((velString.IndexOf(".") > -1) && (velString.Length>velString.IndexOf(".")+ 4)) {
				velText.text = "Velocity: " + velString.Substring(0, velString.IndexOf(".") ) + velString.Substring(velString.IndexOf("."), 3);
			}
		}








	}
}
