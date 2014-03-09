using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour {

	private Vector3 direction;
	private float speed;
	
	// Use this for initialization
	void Start ()
	{
		this.direction = new Vector3(1.0f, 1.0f).normalized;
		this.speed = 0.1f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position += direction * speed;
	}

	void OnCollisionEnter(Collision collision)
	{
		Vector3 normal = collision.contacts[0].normal;
		direction = Vector3.Reflect(direction, normal);
	}

}
