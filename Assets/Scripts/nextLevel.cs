using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
			Application.LoadLevel("NameOfNextScene");
	}
}
