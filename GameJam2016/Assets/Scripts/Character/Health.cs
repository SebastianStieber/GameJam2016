using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {
	
	public Image Heart1;
	public Image Heart2;
	public Image Heart3;
	public Image Heart4;
	public Image Heart5;



	void OnGUI () {
		
		if (GameManager.instance.life == 5) {

			Heart5.enabled = true;
			Heart4.enabled = true;
			Heart3.enabled = true;
			Heart2.enabled = true;
			Heart1.enabled = true;
		}
		
		if (GameManager.instance.life == 4) {
			
			Heart5.enabled = false;
			Heart4.enabled = true;
			Heart3.enabled = true;
			Heart2.enabled = true;
			Heart1.enabled = true;
		}
		
		if (GameManager.instance.life == 3) {
			
			Heart5.enabled = false;
			Heart4.enabled = false;
			Heart3.enabled = true;
			Heart2.enabled = true;
			Heart1.enabled = true;
		} 

		else if (GameManager.instance.life == 2) {
			
			Heart3.enabled = false;
			Heart5.enabled = false;
			Heart4.enabled = false;
			Heart2.enabled = true;
			Heart1.enabled = true;
		}

		else if (GameManager.instance.life == 1) {
			
				Heart5.enabled = false;
				Heart4.enabled = false;
				Heart3.enabled = false;
				Heart2.enabled = false;
			    Heart1.enabled = true;
			}

		else if (GameManager.instance.life == 0){

			SceneManager.LoadScene (SceneManager.GetActiveScene().name);

		}
	}
	}
