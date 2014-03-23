using UnityEngine;
using System.Collections;

public class generat0r : MonoBehaviour {
	
	public Transform Capsule, Cube, Cylinder, Sphere, BoostPad;
	public int counter1 = 0;
	public int gridSize = 30;
	public int gridIncrement = 5;
	
	int counter2 = 0;
	int boostCounter = 0;
	
	// Use this for initialization
	void Start () {
		//use for going through grid to generally spawn a bunch of objects
		//x position
		for (int i = gridSize; i >= 0; i-= gridIncrement) {
			//z position
			for (int j = gridSize; j >= 0; j-= gridIncrement){
				//random number to see if instantiate
				float randomnumber = Random.Range (0f, 100f);
				//%chance to instantiate
				if (randomnumber > 90f){
					Instantiate (Capsule, new Vector3(i, 1f, j), Quaternion.identity);
				}
			}
		}
		//Code for instantiating set # of an object
		//use for if you want any quantity of an object UP TO a max amount
		for (int i = gridSize; i >= 0; i-=gridIncrement) {
			if (counter1 == 10){
				break;
			}
			for (int j = -1; j >= -gridSize; j-= gridIncrement){
				float randomnumber = Random.Range (0f, 100f);
				if (randomnumber > 90f){
					Instantiate (Cube, new Vector3(i, 1f, j), Quaternion.identity);
					counter1++;
					//Debug.Log("Counter = " + counter1);
				}
				if (counter1 == 10){
					break;
				}
			}
		}
		for (int i = -1; i >= -gridSize; i-= gridIncrement) {
			for (int j = gridSize; j >= 0; j-= gridIncrement) {
				float randomnumber = Random.Range (0f, 100f);
				if (randomnumber > 50f) {
					Instantiate (Cylinder, new Vector3 (i, 1f, j), Quaternion.identity);
					
					
				}
				
			}
		}
		//use for an exact number of objects
		//randomly spawns set number of an object within an area
		while (counter2 < 10){
			Instantiate (Sphere, new Vector3(Random.Range(-1,-gridSize), 1f, (Random.Range (-1,-gridSize))), Quaternion.identity);
			counter2++;
		}
		while (boostCounter < 10){
			Instantiate (BoostPad, new Vector3(Random.Range(-gridSize,gridSize), -1f, (Random.Range (-gridSize,gridSize))), Quaternion.Euler(new Vector3(0,Random.Range(90,270),0)));

			boostCounter++;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
