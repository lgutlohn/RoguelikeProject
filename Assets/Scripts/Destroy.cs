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
	
	void OnTriggerEnter(Collider Player) {
		//Destroy(other.gameObject);
		if(Player.gameObject){
			if(sphere){
				//Instantiate(sphere, (transform.position), transform.rotation);
				Destroy(gameObject);
			}		
		}
	}
}

