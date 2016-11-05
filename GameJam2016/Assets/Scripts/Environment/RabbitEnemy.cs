using UnityEngine;
using System.Collections;

public class RabbitEnemy : MonoBehaviour {

	Animator anim;
	public int  hitCount;
	public GameObject prefab;


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

			GameObject laser = Instantiate (prefab);
		}
	}
	
	void Update(){
			
			if (hitCount == 5) 
		{

				Destroy (gameObject);


		}
				

	}
}
