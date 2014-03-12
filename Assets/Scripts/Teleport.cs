using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour
{
	public Transform exit;
	static Transform last;
	
	void OnTriggerEnter ( Collider Player )
	{
		if ( exit == last )
			return;
		
		TeleportToExit( Player );
	}
	
	void OnTriggerExit ( )
	{
		if ( exit == last )
			last = null;
	}
	
	void TeleportToExit ( Collider Player )
	{
		last = transform;
		Player.transform.position = exit.transform.position;
	}
}