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
	public Transform attackPos;
	public Transform direction = null;


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
			laser.transform.position = attackPos.transform.position;
			laserBody.AddForce (Vector2.left * 200);

		}
	}
}
