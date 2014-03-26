using UnityEngine;
using System.Collections;

public class Level3Generation : MonoBehaviour {

	public Transform spikes, goal, powerup, invisWall;
	public int counter1 = 0;
	public int xMax = 20;
	public int xMin = -20;
	public int zMax = 90;
	public int zMin = -20;
	public int gridIncrement = 20;
	public AudioClip levelLoad;
	
	int counter2 = 0;
	
	// Use this for initialization
	void Start () {

		audio.PlayOneShot (levelLoad, .5f);
				//use for going through grid to generally spawn a bunch of objects
				//x position
				for (int i = xMax; i >= xMin; i-= gridIncrement) {
						//z position
						for (int j = zMax; j >= zMin; j-= gridIncrement) {
								//random number to see if instantiate
								float randomnumber = Random.Range (0f, 100f);
								//%chance to instantiate
								if (randomnumber > 50f) {
										Instantiate (spikes, new Vector3 (i, -1.69f, j), Quaternion.identity);
								}
						}
				}
				float goalLocation = Random.Range (-20f, 20f);
				Instantiate (goal, new Vector3 (goalLocation, -0.8237286f, 127.002f), Quaternion.identity);


				Instantiate (powerup, new Vector3 (-50.99167f, -1.606247f, -55.4191f), Quaternion.identity);
				Instantiate (powerup, new Vector3 (50.99167f, -1.606247f, -55.4191f), Quaternion.identity);
	
				float randomWall = Random.Range (0f, 100f);
				if (randomWall > 50f) {
						Instantiate (invisWall, new Vector3 (-32.87909f, 0.1531696f, -53.05298f), Quaternion.identity);
				} else {
						Instantiate (invisWall, new Vector3 (32.87909f, 0.1531696f, -53.05298f), Quaternion.identity);
				}
		}
	// Update is called once per frame
	void Update () {
	
	}
}
