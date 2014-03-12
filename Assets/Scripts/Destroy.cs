using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
	public GameObject sphere;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		if(other.tag == "Player"){
			//if(sphere){
				//Instantiate(sphere, (transform.position), transform.rotation);
				Destroy(gameObject);
			//}		
		}
	}
}

