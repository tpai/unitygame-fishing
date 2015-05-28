using UnityEngine;
using System.Collections;

public class FishController : MonoBehaviour {

	public int hp = 2;
	public float speed = 20f;

	void Start () {

		speed = Random.Range (5f, 20f);

		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}

	void MinusHP (int amt) {
		hp -= amt;
		if (hp <= 0) {
			hp = 0;
			Destroy (gameObject);
		}
	}
}
