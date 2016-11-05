using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
=======

>>>>>>> 2521100b310ee81785854c85b2a15d9138bf8637

public class Thorn : MonoBehaviour {


	public void Die()
	{
<<<<<<< HEAD
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().Restart ();
		GameManager.instance.life--;

=======
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		GameManager.instance.life = 3;
>>>>>>> 2521100b310ee81785854c85b2a15d9138bf8637
	}
		
}
