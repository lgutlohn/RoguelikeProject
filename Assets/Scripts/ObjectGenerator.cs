using UnityEngine;
using System.Collections;

public class ObjectGenerator : MonoBehaviour {
	
	//x: -59.5, 58.5
	//z: -73, 138
	
	public Transform blocker, sphere, diagonalLeft, diagonalRight, goal;
	public int counter1 = 0;
	public int xMax = 58;
	public int xMin = -59;
	public int zMax = 120;
	public int zMin = -55;
	public int gridIncrement = 8;
	
	int counter2 = 0;
	
	// Use this for initialization
	void Start () {
				float randomnumber = Random.Range (0f, 100f);
				//%chance to have blocker rotated one way or another
				if (randomnumber > 50f){
					Instantiate (blocker, new Vector3(-0.2562943f, -17.53263f, 26.63985f), Quaternion.Euler (0f, -90f, 90f));
				}
				else{
					Instantiate (blocker, new Vector3(-0.2562943f, -17.53263f, 26.63985f), Quaternion.Euler (270f, 0f, 0f));
			}

				//%chance to spawn sphere on a grid
				for (int i = xMax; i >= xMin; i-= gridIncrement) {
					for (int j = zMax; j >= zMin; j-= gridIncrement) {
						float random2 = Random.Range (0f, 100f);
						if (random2 > 90f) {
							Instantiate (sphere, new Vector3 (i, 1f, j), Quaternion.identity);
							
							
						}
						
					}
				}
		float randomDiagonal = Random.Range (0f, 100f);
		//%chance to have diagonal blocks rotated one way or another
		if (randomDiagonal > 50f){
			Instantiate (diagonalLeft, new Vector3(-37.89038f, 2.584461f, 117.9307f), Quaternion.Euler (0f, -50f, -90f));
			Instantiate (diagonalRight, new Vector3(39.11375f, 2.584461f, 118.6722f), Quaternion.Euler (0f, 50f, -90f));
		}
		else{
			Instantiate (diagonalLeft, new Vector3(-44.70161f, 2.584461f, 115.702f), Quaternion.Euler (0f, -118.8889f, 90f));
			Instantiate (diagonalRight, new Vector3(44.22133f, 2.584461f, 116.8078f), Quaternion.Euler (0f, 118.7113f, 90f));
		}

		//instantiate goal
		float goalLocation = Random.Range (-20f, 20f);
		Instantiate (goal, new Vector3 (goalLocation, -0.8237286f, 127.002f), Quaternion.identity);



		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
