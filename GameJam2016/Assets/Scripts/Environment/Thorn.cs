using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Thorn : MonoBehaviour {


	public void Die()
	{
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().Restart ();
		GameManager.instance.life--;

	}
		
}
