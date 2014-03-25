using UnityEngine;
using System.Collections;

public class AddShots : MonoBehaviour {
	public CannonControls cannon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Bullet") {
			cannon.shotsLeft++;
			GameObject.Destroy (this.gameObject);
		}


	}
}
