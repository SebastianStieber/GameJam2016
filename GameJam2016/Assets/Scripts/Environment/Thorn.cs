using UnityEngine;
using System.Collections;

public class Thorn : MonoBehaviour {


	public void Die()
	{
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().Restart ();
		GameManager.instance.life--;
	}
		
}
