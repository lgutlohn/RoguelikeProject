using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	
	public Transform Rock;
	public int counter2 = 0;
	public int gridSize = 30;

	void Start () {

		while (counter2 < 10){
			Instantiate (Rock, new Vector3(Random.Range(-1,-gridSize), 1f, (Random.Range (-1,-gridSize))), Quaternion.identity);
			counter2++;
		}

	}
	
	void Update () {
		
	}
}
