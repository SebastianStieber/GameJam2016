using UnityEngine;
using System.Collections;

public class BossShot : MonoBehaviour {

	public GameObject shield;

	void Start () 
	{
		shield = GameObject.FindGameObjectWithTag("PlayerFairy");
		
	}

	void OnTriggerEnter2D(Collider2D collider)

	{
		if (shield.activeInHierarchy == true && collider.tag == "Player") 
		{
			shield.SetActive (false);
		}
		else if (collider.tag == "Player") 
		{
			Destroy (gameObject);
			GameManager.instance.life--;
		}
	}
}
