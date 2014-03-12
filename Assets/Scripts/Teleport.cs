﻿using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour
{
	public Transform exit;
	static Transform last;
	
	void OnTriggerEnter ( Collider other )
	{
		if ( exit == last )
			return;
		
		TeleportToExit( other );
	}
	
	void OnTriggerExit ( )
	{
		if ( exit == last )
			last = null;
	}
	
	void TeleportToExit ( Collider other )
	{
		if (other.tag == "Player") {
			last = transform;
			other.transform.position = exit.transform.position;
		}
	}
}