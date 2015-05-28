using UnityEngine;
using System.Collections;

public class FishController : MonoBehaviour {

	public int hp = 2;
	public float speed = 20f;

	Animator anim;

	void Start () {

		anim = GetComponentInChildren<Animator> ();

		speed = Random.Range (5f, 20f);

		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}

	void MinusHP (int amt) {
		hp -= amt;
		if (hp <= 0) {
			hp = 0;
			anim.SetBool("die", true);
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<BoxCollider> ().enabled = false;
		}
	}
}
