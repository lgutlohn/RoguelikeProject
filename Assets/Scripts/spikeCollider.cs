using UnityEngine;
using System.Collections;

public class spikeCollider : MonoBehaviour {

	public GameObject spikes;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Destroy (other.gameObject);
			Destroy(spikes);
			}
	}
}

