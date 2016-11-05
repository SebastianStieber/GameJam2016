using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class Thorn : MonoBehaviour {


	public void Die()
	{

		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		GameManager.instance.life = 3;

	}
		
}
