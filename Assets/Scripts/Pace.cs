using UnityEngine;
using System.Collections;

public class Pace : MonoBehaviour {

	public float shift;
	public float left;
	public float right;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(shift,0,0);
		if (transform.position.x < left || transform.position.x > right) {
			shift *= -1;		
		}
	
	}
}
