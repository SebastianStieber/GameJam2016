using UnityEngine;
using System.Collections;

public class RabbitEnemy : MonoBehaviour {

	Animator anim;
	Transform playerPos;
	public Vector3 speed;
	public GameObject attackPos;
	public float force = 1f;


	bool hit;

	public float cooldown = 1;
	public int  hitCount;
	public GameObject prefab;



	void Start()
	{

		anim = GetComponent<Animator> ();
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

		if (hit == true) 
		{
			GameObject laser = Instantiate (prefab);
			laser.transform.position = GameObject.FindGameObjectWithTag ("Player").transform.position - attackPos.transform.position;

			Vector3 direction = GameObject.FindGameObjectWithTag ("Player").transform.position - attackPos.transform.position;
			laser.GetComponent<Rigidbody2D> ().AddForce(direction * force, ForceMode2D.Impulse);


			hit = false;

		}


	
	}
		
		
}
