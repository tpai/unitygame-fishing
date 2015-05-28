using UnityEngine;
using System.Collections;

public class CannonShooting : CannonBase {

	[SerializeField] private Transform tunnel;
	[SerializeField] private GameObject bullet;
	bool holdFire = false;
	public float firingRate = .5f;

	void Update () {
		if (CannonRotation.p1) {
			if (Input.GetKey (KeyCode.RightControl)) {
				Shoot ();
			}
		}
		else {
			if (Input.GetKey (KeyCode.Space)) {
				Shoot ();
			}
		}
	}

	void Shoot () {
		if (!holdFire) {
			Instantiate (bullet, tunnel.position + Vector3.forward, tunnel.rotation);
			StartCoroutine ("HoldFire", firingRate);
		}
	}

	IEnumerator HoldFire (float rate) {
		holdFire = true;
		yield return new WaitForSeconds (rate);
		holdFire = false;
	}
}
