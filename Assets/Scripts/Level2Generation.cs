using UnityEngine;
using System.Collections;

public class Level2Generation : MonoBehaviour {
	
	//x: -59.5, 58.5
	//z: -73, 138
	
	public Transform spinner, goal, powerup, invisWall;
	public int counter1 = 0;
	public int xMax = 58;
	public int xMin = -59;
	public int zMax = 120;
	public int zMin = -55;
	public int gridIncrement = 8;
	public AudioClip levelLoad;
	
	int counter2 = 0;
	
	// Use this for initialization
	void Start () {

		audio.PlayOneShot (levelLoad, .5f);


		Instantiate (spinner, new Vector3(0f, 0.99485023f, 26.76897f), Quaternion.identity);


		
		//instantiate goal
		float goalLocation = Random.Range (-20f, 20f);
		Instantiate (goal, new Vector3 (goalLocation, -0.8237286f, 127.002f), Quaternion.identity);

		Instantiate (powerup, new Vector3 (-50.99167f, -1.606247f, -55.4191f), Quaternion.identity);
		Instantiate (powerup, new Vector3 (50.99167f, -1.606247f, -55.4191f), Quaternion.identity);
		
		float randomWall = Random.Range (0f, 100f);
		if (randomWall > 50f) {
			Instantiate (invisWall, new Vector3(-32.87909f, 0.1531696f, -53.05298f), Quaternion.identity);
		}
		else{
			Instantiate (invisWall, new Vector3(32.87909f, 0.1531696f, -53.05298f), Quaternion.identity);
		}
		
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
