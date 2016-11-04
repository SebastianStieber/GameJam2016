using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Wall : MonoBehaviour {

	public WallManager wallManager;

	public Vector3 size;

	GameObject wall, innerWall;
	Vector3 oldSize;
	Color oldColor;
	float oldBorderScale;
	
	void Start () {
		wall = transform.GetChild (0).gameObject;
		innerWall = transform.GetChild (1).gameObject;

		wall.transform.localScale = size;
		innerWall.transform.localScale = size - new Vector3 (wallManager.borderWidth, wallManager.borderWidth, wallManager.borderWidth) * wallManager.borderScale * 2;
		innerWall.transform.position = transform.position;

	}

	void Update () {
		if (oldSize != size || wallManager.borderScale != oldBorderScale) {
			wall.transform.localScale = size;
			innerWall.transform.localScale = size - new Vector3 (wallManager.borderWidth * wallManager.borderScale * 2, wallManager.borderWidth* wallManager.borderScale * 2, -1) ;
			innerWall.transform.position = transform.position + new Vector3(0, 0, -1);
		}
		if (oldColor != wallManager.color) {
			wall.GetComponent<Renderer> ().sharedMaterial.color = wallManager.color;
			innerWall.GetComponent<Renderer> ().sharedMaterial.color = new Color(wallManager.color.r + .2f, wallManager.color.g + .2f, wallManager.color.b + .2f);

		}

		oldColor = wallManager.color;
		oldSize = size;
		oldBorderScale = wallManager.borderScale;
	}
}
