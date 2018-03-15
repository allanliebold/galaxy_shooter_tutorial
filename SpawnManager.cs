using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	[SerializeField]
	private GameObject enemyShipPrefab;
	[SerializeField]
	private GameObject[] powerUps;
	
	IEnumerator EnemySpawn() {
		while (true) {
			Instantiate(enemyShipPrefab, new Vector3(Random.Range(-7f, 7f), 7, 0))	
		}
	}
}
