using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float speed = 20f;

	void Update () {
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Fish") {
			other.SendMessage("MinusHP", 1);
			Destroy (gameObject);
		}
	}
}
