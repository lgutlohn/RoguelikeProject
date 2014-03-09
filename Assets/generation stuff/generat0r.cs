using UnityEngine;
using System.Collections;

public class generat0r : MonoBehaviour {

	public Transform Capsule, Cube, Cylinder, Sphere;
	public int counter1 = 0;

	int counter2 = 0;

	// Use this for initialization
	void Start () {
		//use for going through grid to generally spawn a bunch of objects
		//x position
		for (int i = 9; i >= 0; i--) {
			//z position
			for (int j = 9; j >= 0; j--){
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
		for (int i = 9; i >= 0; i--) {
			if (counter1 == 10){
				break;
			}
			for (int j = -1; j >= -9; j--){
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
			for (int i = -1; i >= -9; i--) {
				for (int j = 9; j >= 0; j--) {
								float randomnumber = Random.Range (0f, 100f);
								if (randomnumber > 50f) {
											Instantiate (Cylinder, new Vector3 (i, 1f, j), Quaternion.identity);
											

										}

								}
						}
		//use for an exact number of objects
		//randomly spawns set number of an object within an area
		while (counter2 < 10){
					Instantiate (Sphere, new Vector3(Random.Range(-1,-9), 1f, (Random.Range (-1,-9))), Quaternion.identity);
			counter2++;
		}
			
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
