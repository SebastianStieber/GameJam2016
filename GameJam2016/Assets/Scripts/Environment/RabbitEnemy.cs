using UnityEngine;
using System.Collections;

public class RabbitEnemy : MonoBehaviour {

	Animator anim;
	Rigidbody2D laserBody;
	Transform playerPos;

	bool hit;

	public int  hitCount;
	public GameObject prefab;
	public GameObject player;


	void Start()
	{

		anim = GetComponent<Animator> ();
		laserBody = GetComponent<Rigidbody2D> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerPos = player.transform;
		hitCount = 0;
	

	}

	void OnCollisionEnter2D (Collision2D other)
	{ 
		if (other.gameObject.tag == "Arrow" && hitCount >= 0) 
			
		{
			hitCount++;
			hit = true;
		}
			
	}
	
	void Update()
	{
			
			if (hitCount == 5) 
		{
				Destroy (gameObject);

		}
			


	
	}

	void FixedUpdate()
	{
		if (hit == true) 
		{
			GameObject laser = Instantiate (prefab);
			laser.transform.position = this.transform.position;
			laserBody.AddForce ((playerPos.position - this.transform.position) * 200);

		}
	}
}
