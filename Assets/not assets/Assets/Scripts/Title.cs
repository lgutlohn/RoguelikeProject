using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
	
	public KeyCode buttonToPush = KeyCode.Space;
	public string nextLevel = "Instructions";
	
	// Use this for initialization
	void Start () {
		
	}
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (buttonToPush)) {
			Application.LoadLevel(nextLevel);
		}	
	}
}
