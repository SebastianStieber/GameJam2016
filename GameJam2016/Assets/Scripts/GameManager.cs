using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public int life;

	void Awake()
	{
		life = 3;

		if (instance == null)

		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

	void Update(){
		
	}


}
