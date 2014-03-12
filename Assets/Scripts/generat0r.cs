using UnityEngine;
using System.Collections;

public class generat0r : MonoBehaviour {

	//x: -59.5, 58.5
	//z: -73, 138
	
	public Transform Object1, Object2, Object3, Object4;
	public int counter1 = 0;
	public int xMax = 58;
	public int xMin = -59;
	public int zMax = 138;
	public int zMin = -73;
	public int gridIncrement = 5;
	
	int counter2 = 0;
	
	// Use this for initialization
	void Start () {
		//use for going through grid to generally spawn a bunch of objects
		//x position
		for (int i = xMax; i >= xMin; i-= gridIncrement) {
			//z position
			for (int j = zMax; j >= zMin; j-= gridIncrement){
				//random number to see if instantiate
				float randomnumber = Random.Range (0f, 100f);
				//%chance to instantiate
				if (randomnumber > 90f){
					Instantiate (Object1, new Vector3(i, 1f, j), Quaternion.identity);
				}
			}
		}
//		//Code for instantiating set # of an object
//		//use for if you want any quantity of an object UP TO a max amount
//		for (int i = xMax; i >= xMin; i-=gridIncrement) {
//			if (counter1 == 10){
//				break;
//			}
//			for (int j = zMax; j >= zMin; j-= gridIncrement){
//				float randomnumber = Random.Range (0f, 100f);
//				if (randomnumber > 90f){
//					Instantiate (Object2, new Vector3(i, 1f, j), Quaternion.identity);
//					counter1++;
//					//Debug.Log("Counter = " + counter1);
//				}
//				if (counter1 == 10){
//					break;
//				}
//			}
//		}
//		for (int i = xMax; i >= xMin; i-= gridIncrement) {
//			for (int j = zMax; j >= zMin; j-= gridIncrement) {
//				float randomnumber = Random.Range (0f, 100f);
//				if (randomnumber > 50f) {
//					Instantiate (Object3, new Vector3 (i, 1f, j), Quaternion.identity);
//					
//					
//				}
//				
//			}
//		}
		//use for an exact number of objects
		//randomly spawns set number of an object within an area
		while (counter2 < 50){
			Instantiate (Object4, new Vector3(Random.Range(xMax,xMin), 10f, (Random.Range (zMax,zMin))), Quaternion.Euler (0f, Random.Range (0f, 360f), 0f));
			counter2++;
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
