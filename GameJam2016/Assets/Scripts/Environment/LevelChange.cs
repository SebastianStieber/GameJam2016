using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {

	public string level;

	public void Change()
	{
		Application.LoadLevel (level);
	}
}
