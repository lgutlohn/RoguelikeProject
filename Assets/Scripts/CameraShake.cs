using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

	public float shakeStrength = 5f;
	public float shake = 1f;
	private float nextFireTime;
	public float reloadTime = 1f;
	
	Vector3 originalPosition;
	
	void Start()
	{
		originalPosition = transform.localPosition;
	}
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.LeftShift) && Time.time >= nextFireTime)
		{
			nextFireTime = Time.time + reloadTime;
			shake = shakeStrength;
		}
		
		Camera.main.transform.localPosition = originalPosition + (Random.insideUnitSphere * shake);

		shake = Mathf.MoveTowards(shake, 0, Time.deltaTime * shakeStrength);
		
		if(shake == 0)
		{
			Camera.main.transform.localPosition = originalPosition;
		}
	}

}