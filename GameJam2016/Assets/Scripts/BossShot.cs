using UnityEngine;
using System.Collections;

public class BossShot : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			Destroy (gameObject);
			GameManager.instance.life--;
		}
	}
}
