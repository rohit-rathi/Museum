using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger> ();
		trigger.ExpectCollider (collider);
	}
}
