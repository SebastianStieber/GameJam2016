using UnityEngine;
using System.Collections;

public class RabbitEnemy : MonoBehaviour {

	Animator anim;
	Rigidbody2D laserBody;
	Transform playerPos;
	public Vector3 speed;


	bool hit;

	public float cooldown = 1;
	public int  hitCount;
	public GameObject prefab;
	public GameObject player;


	void Start()
	{

		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");
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
		playerPos = player.transform;
			
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

			laserBody = laser.GetComponent<Rigidbody2D>();

			float direction = playerPos.position.x - transform.position.x;
		
			laserBody.velocity = new Vector3 (direction,0,0);

			hit = false;

		}
	}
		
}
