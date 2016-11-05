using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
=======

>>>>>>> 6d604a4ad3f4a5f6de1175de1807b023a4277f8f

public class Thorn : MonoBehaviour {


	public void Die()
	{
<<<<<<< HEAD


=======
		
>>>>>>> 6d604a4ad3f4a5f6de1175de1807b023a4277f8f
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		GameManager.instance.life = 3;

	}
		
}
