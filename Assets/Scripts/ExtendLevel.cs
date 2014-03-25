using UnityEngine;
using System.Collections;
public class ExtendLevel : MonoBehaviour {
	public GameObject floor;
	public float delay;
	float hitTime = -100;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time == hitTime + delay) {
			Instantiate(floor,new Vector3(0,0,transform.root.position.z+ floor.renderer.bounds.size.z+(125/2)),Quaternion.identity);
			GameObject.Destroy(this.gameObject);

		}
	
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Bullet") {
			hitTime = Time.time;
		}

	}
}
