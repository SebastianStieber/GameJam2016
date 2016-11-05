using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public Vector3 speed;

	bool fired;
	float direction;

	void Start () {

	}

	void Update () {
		if (fired) {
			transform.position += speed * direction;
		} 
	}

	public void Fire(float direction){
		this.direction = direction;
		fired = true;
	}

	void OnCollisionEnter2D(Collision2D collision){
		Destroy (gameObject);
	}
		
}
