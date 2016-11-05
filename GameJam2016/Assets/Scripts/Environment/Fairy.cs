using UnityEngine;
using System.Collections;

public class Fairy : MonoBehaviour {

	public GameObject fee;

	//public GameObject fee;
	public void Collect ()
	{
		if (fee.activeInHierarchy == false) {
			Destroy (gameObject);
			fee.SetActive (true);

		}
	}
	}
		
	



