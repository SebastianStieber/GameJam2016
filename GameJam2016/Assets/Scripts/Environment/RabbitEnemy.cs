using UnityEngine;
using System.Collections;

public class RabbitEnemy : MonoBehaviour {

	Animator anim;
	Rigidbody2D laserBody;
	Transform playerPos;
	public Vector3 speed;
	float direction;

	bool hit;

	public int  hitCount;
	public GameObject prefab;
	public GameObject player;
	public Transform attackPos;


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
			laser.transform.position += speed * 3;
			hit = false;

		}
	}
		
}
