using UnityEngine;
using System.Collections;

public class FishAnimEvent : MonoBehaviour {

	public void DestroyFish () {
		Destroy (transform.parent.gameObject);
	}
}
