using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObject : MonoBehaviour {

	private static int count = 0;

	public void IncrementCount() {
		count++;
	}

	public int GetCount() {
		return count;
	}

	public void SetCountToOne() {
		count = 1;
	}
}
