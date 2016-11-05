using UnityEngine;
using System.Collections;

public class Bow : MonoBehaviour {

	public GameObject prefab;
	public Vector3 distance;

	void Start () {
	
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject arrow = Instantiate (prefab);
			arrow.transform.position = transform.position + distance * GetComponent<Controller> ().collisions.faceDir;
			arrow.GetComponent<Arrow>().Fire(GetComponent<Controller> ().collisions.faceDir);
		}
	}
}
