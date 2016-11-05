using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Resources;

public class Boss : MonoBehaviour {

	public Transform attackPosition;
	public float cooldown = 2f;
	public GameObject prefab;
	public float force = 1f;

	float timer; 

	void Start () {
	
	}

	void Update () {
		if (timer >= cooldown) {
			timer = 0;
			Attack ();
		}

		timer += Time.deltaTime;
	}

	void Attack(){
		GameObject shot = Instantiate (prefab);
		shot.transform.position = attackPosition.position;

		Vector3 direction = GameObject.FindGameObjectWithTag ("Player").transform.position - attackPosition.position;
		direction.Normalize ();
		shot.GetComponent<Rigidbody2D> ().AddForce(direction * force, ForceMode2D.Impulse);

		GetComponent<Animator> ().SetBool ("Attack", true);

		StartCoroutine (Reset ());
	} 

	IEnumerator Reset(){
		yield return new WaitForSeconds (.1f);

		GetComponent<Animator> ().SetBool ("Attack", false);


	}
}
