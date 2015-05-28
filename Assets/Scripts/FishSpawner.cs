using UnityEngine;
using System.Collections;

public class FishSpawner : MonoBehaviour {

	[SerializeField] private GameObject[] fishPrefabs;

	void Start () {
		 InvokeRepeating ("SpawnFish", .1f, Random.Range (.3f, 1f));
	}

	GameObject fishPrefab;
	Quaternion rotation = Quaternion.identity;
	int direction;

	void SpawnFish () {

		fishPrefab = fishPrefabs [Random.Range (0, fishPrefabs.Length)];
		direction = Random.Range (0, 2);
		rotation.eulerAngles = new Vector3 (0f, (direction == 1) ? 90f : -90f, 0f);


		Instantiate (
			fishPrefab,
			new Vector3 (
				(direction==1) ? -43f : 43f,
				7.5f,
				Random.Range (-12f, 12f)
			),
			rotation
		);
	}
}
