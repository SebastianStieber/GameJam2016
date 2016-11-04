using UnityEngine;
using System.Collections;

public class LifeUp : MonoBehaviour {

	public void Up (){

		if (GameManager.instance.life <= 5) {

			GameManager.instance.life++;
			Destroy (gameObject);
		}
		
	}
}
