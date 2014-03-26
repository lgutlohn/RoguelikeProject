using UnityEngine;
using System.Collections;

public class AddShots : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		GameObject cannon = GameObject.Find("Cannon");
		if (other.tag == "Bullet") {
			cannon.GetComponent<CannonControls>().shotsLeft++;
			GameObject.Destroy (this.gameObject);
		}


	}
}
