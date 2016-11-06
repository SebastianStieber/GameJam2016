using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class FeatureButton : MonoBehaviour {

	public GameObject[] explosions;


	void Start () {
		transform.GetChild (1).gameObject.SetActive (false);
		foreach (GameObject explosion in explosions) {
			explosion.SetActive (false);
		}
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			GetComponent<Animator>().SetBool ("Triggered", true);
			transform.GetChild (0).position = new Vector3 (transform.GetChild (0).position.x, transform.GetChild (0).position.y, -2);
			transform.GetChild (1).gameObject.SetActive (true);

			foreach (GameObject explosion in explosions) {
				explosion.SetActive (true);
				explosion.transform.position = new Vector3 (explosion.transform.position.x, explosion.transform.position.y, -5);
				explosion.transform.GetChild (0).gameObject.GetComponent<Animator> ().SetBool ("Triggered", true);
				explosion.GetComponent<AudioSource> ().Play ();
			}
			StartCoroutine (Reset ());
		}
	}

	IEnumerator Reset(){
		yield return new WaitForSeconds (1f);
		GetComponent<Animator> ().SetBool ("Triggered", false);
		transform.GetChild (1).gameObject.SetActive (false);

		foreach (GameObject explosion in explosions) {
			explosion.transform.GetChild (0).gameObject.GetComponent<Animator> ().SetBool ("Triggered", false);
			explosion.SetActive (false);
		}
	}
}
