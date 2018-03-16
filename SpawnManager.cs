using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	[SerializeField]
	private GameObject enemyShipPrefab;
	[SerializeField]
	private GameObject[] powerUps; // an array to store power up objects to be chosen at random
	
	IEnumerator EnemySpawn() {
		while (true) {
			Instantiate(enemyShipPrefab, new Vector3(Random.Range(-7f, 7f), 7, 0), Quaternion.identity)	
		}
	}
	
	IEnumerator PowerUpSpawn() {
		while (true) {
			
		}
	}
}
