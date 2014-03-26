using UnityEngine;
using System.Collections;

public class InstanceGenerator : MonoBehaviour {
	public Transform Capsule, Cube, Cylinder, Sphere, BoostPad, PowerUp;
	int counter1 = 0;
	float gridEnd;
	float gridStart;
	float gridLeft;
	float gridRight;
	int gridIncrement = 5;

	int counter2 = 0;
	int boostCounter = 0;
	int powerUpCounter = 0;

	// Use this for initialization
	void Start () {
		GameObject cannon = GameObject.Find("Cannon");
		int level = cannon.GetComponent<CannonControls> ().Level;
		Debug.Log ("Level " + level.ToString ());
		gridEnd = transform.position.z + transform.root.renderer.bounds.size.z+(125/2);
		gridStart = transform.position.z+(125/2);
		gridRight = 30;
		gridLeft = -30;
		Debug.Log(gridStart.ToString()+" "+gridEnd.ToString());

		//use for going through grid to generally spawn a bunch of objects
		//x position
		for (float i = gridEnd; i >= gridStart; i-= gridIncrement) {
			//z position
			for (float j = gridRight; j >= gridLeft; j-= gridIncrement){
				//random number to see if instantiate
				float randomnumber = Random.Range (0f, 100f);
				//%chance to instantiate
				if (randomnumber > 100f-level){
					Instantiate (Capsule, new Vector3(j, 2f, i), Quaternion.identity);
				}
			}
		}
		//Code for instantiating set # of an object
		//use for if you want any quantity of an object UP TO a max amount
		for (float i = gridEnd; i >= gridStart; i-=gridIncrement) {

			if (counter1 == 10){
				break;
			}
			for (float j = gridRight; j >= gridLeft; j-= gridIncrement){
				float randomnumber = Random.Range (0f, 100f);
				if (randomnumber > 90f-level){
					Instantiate (Cube, new Vector3(j, 2f, i), Quaternion.identity);
					counter1++;
					//Debug.Log("Counter = " + counter1);
				}
				if (counter1 == 10){
					break;
				}
			}
		}
		for (float i = gridEnd; i >= gridStart; i-= gridIncrement) {
			for (float j = gridRight; j >= gridLeft; j-= gridIncrement) {
				float randomnumber = Random.Range (0f, 100f);
				if (randomnumber > 100f-((float)level/10f)) {
					Instantiate (Cylinder, new Vector3 (j, 2f, i), Quaternion.identity);
					
					
				}
				
			}
		}
		//use for an exact number of objects
		//randomly spawns set number of an object within an area
		while (counter2 < 10+level){
			Instantiate (Sphere, new Vector3(Random.Range(gridLeft,gridRight), 2f, (Random.Range (gridEnd,gridStart))), Quaternion.identity);
			counter2++;
		}
		while (boostCounter < 10+level){
			Instantiate (BoostPad, new Vector3(Random.Range(gridLeft,gridRight), 2f, (Random.Range (gridEnd,gridStart))), Quaternion.Euler(new Vector3(0,Random.Range(90,270),0)));
			Debug.Log(boostCounter.ToString());
			boostCounter++;
		}
		while (powerUpCounter < 10){
			Instantiate (PowerUp, new Vector3(Random.Range(gridLeft,gridRight), 3f, (Random.Range (gridEnd,gridStart))), Quaternion.Euler(new Vector3(0,Random.Range(90,270),0)));
			
			powerUpCounter++;
		}
		Debug.Log(gridStart.ToString()+" "+gridEnd.ToString());



	
	}

	
	// Update is called once per frame
	void Update () {
		GameObject.Destroy (collider);
		GameObject.Destroy (GetComponent<MeshRenderer>());
	
	}
}
