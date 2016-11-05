using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Stone : MonoBehaviour {

	public float force = 1f;

	public void Move(int direction){
		Vector3 movement = new Vector3 (force, 0, 0) * direction;
		transform.position = Vector3.Lerp (transform.position, transform.position + movement, Time.deltaTime);
	}
}
