using UnityEngine;
using System.Collections;

public class Thorn : MonoBehaviour {


	public void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
		GameManager.instance.life = 3;
	}
		
}
