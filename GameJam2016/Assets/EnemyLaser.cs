using UnityEngine;
using System.Collections;

public class EnemyLaser : MonoBehaviour {

	public void EnemyAttack()

	{
		GameManager.instance.life--;
	}
}
