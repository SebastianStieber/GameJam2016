using UnityEngine;
using System.Collections;

public class RabbitEnemy : MonoBehaviour {

	Animator anim;
	public int  hitCount;
	public GameObject prefab;
	Rigidbody2D laserBody;
	GameObject player;

	void Awake()
	{
		hitCount = 0;
	}

	void Start()
	{
		anim = GetComponent<Animator> ();
		laserBody = GetComponent<Rigidbody2D> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnCollisionEnter2D (Collision2D other)
	{ 
		if (other.gameObject.tag == "Arrow" && hitCount >= 0) {
			
			hitCount++;

			GameObject laser = Instantiate (prefab);
			laser.transform.position = this.transform.position;
			laserBody.AddForce (transform.up * Time.deltaTime);
		}
	}
	
	void Update(){
			
			if (hitCount == 5) 
		{

				Destroy (gameObject);


		}
				

	}
}
