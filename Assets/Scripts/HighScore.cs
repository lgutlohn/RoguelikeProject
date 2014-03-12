using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	//"static" keyword tells Unity to PERSIST this variable across level changes
	//because, technically, this now lives inside the codebase
	static int highScore = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//press R to reload level
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel (1);
		}

		//game mechanic
		if (Input.GetKeyDown (KeyCode.Space)) {
			highScore++;
		}

		GetComponent<TextMesh> ().text = highScore.ToString ();
	}
}
