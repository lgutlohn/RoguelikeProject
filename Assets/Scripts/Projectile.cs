using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public float projectileSpeed = 1f;
	public float projectileRange = 500f;
	public Rigidbody cannon;
	public CannonControls cannonScript;
	float projectileDistance;
	// Use this for initialization
	void Start () {
		Debug.Log (rigidbody.velocity.magnitude.ToString());
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (rigidbody.velocity.magnitude.ToString());
	

//		projectileDistance += Time.deltaTime * projectileSpeed;
//		if(projectileDistance >= projectileRange){
//			GameObject.Destroy(this.gameObject);
//		}
		if (rigidbody.velocity.magnitude <= 0.1) {
			GameObject cannon = GameObject.Find("Cannon");
			//The decimal makes sure the cannons hieght will alway be 1
			cannon.rigidbody.MovePosition(this.rigidbody.position + new Vector3(0f,1.3468741f,0f));
			cannon.GetComponent<CannonControls>().fired=false;
			GameObject.Destroy(this.gameObject);
	     	}
	}
}
