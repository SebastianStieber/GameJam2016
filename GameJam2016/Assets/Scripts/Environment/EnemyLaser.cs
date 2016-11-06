using UnityEngine;
using System.Collections;

public class EnemyLaser : MonoBehaviour {
	
	public float timer;
	public GameObject shield;

	void Awake(){
		shield = GameObject.FindGameObjectWithTag ("PlayerFairy");
	}

	public void EnemyAttack()
	{
		if (shield.activeInHierarchy == true) {
			shield.SetActive (false);
			Destroy (gameObject);

		} else {
				GameManager.instance.life--;
				Destroy (gameObject);
		
		}
	}

	void Update(){
		timer -= Time.deltaTime;
		if (timer<=0){
			Destroy (gameObject);
		}
	}
}
