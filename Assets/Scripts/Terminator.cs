using UnityEngine;
using System.Collections;

public class Terminator : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		Destroy (other.gameObject);
	}
}
