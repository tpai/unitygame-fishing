using UnityEngine;
using System.Collections;

public class CannonRotation : MonoBehaviour {
	
	[SerializeField] private Transform top;
	public float rotSpeed = 100f;
	public bool p1 = false;

	void Update () {
		if (p1) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				Turn ("Left");
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				Turn ("Right");
			}
		}
		else {
			if (Input.GetKey (KeyCode.A)) {
				Turn ("Left");
			}
			if (Input.GetKey (KeyCode.D)) {
				Turn ("Right");
			}
		}
	}

	void Turn (string dir) {
		switch (dir) {
		case "Left":
			top.Rotate (new Vector3 (0f, -1f, 0f) * rotSpeed * Time.deltaTime);
			break;
		case "Right":
			top.Rotate (new Vector3 (0f, 1f, 0f) * rotSpeed * Time.deltaTime);
			break;
		}

		Vector3 rot = top.localRotation.eulerAngles;
		Quaternion topRotation = top.localRotation;
		topRotation.eulerAngles = new Vector3 (rot.x, Mathf.Clamp (rot.y, 90f, 270f), rot.z);
		top.localRotation = topRotation;
	}
}
