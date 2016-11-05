using UnityEngine;
using System.Collections;

public class RabbitEnemy : MonoBehaviour {

	Animator anim;
	public int  hitCount;

	void Awake()
	{
		hitCount = 0;
	}

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void OnCollisionEnter2D (Collision2D other)
	{ 
		if (other.gameObject.tag == "Arrow" && hitCount >= 0) {
			
			hitCount++;


		}
	}
	
	void Update(){
			
			if (hitCount == 5) 
		{

				Destroy (gameObject);


		}
				

	}
}
