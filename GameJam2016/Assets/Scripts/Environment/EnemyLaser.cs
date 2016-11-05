using UnityEngine;
using System.Collections;

public class EnemyLaser : MonoBehaviour {
	
	public float timer;
	public void EnemyAttack()

	{
		GameManager.instance.life--;
		Destroy (gameObject);
	}

	void Update(){
		timer -= Time.deltaTime;
		if (timer<=0){
			Destroy (gameObject);
		}
	}
}
