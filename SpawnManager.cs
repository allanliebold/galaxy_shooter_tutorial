using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	[SerializeField]
	private GameObject enemyShipPrefab;
	[SerializeField]
	private GameObject[] powerUps; // an array to store power up objects to be chosen at random

	void Start () {
		StartCoroutine(EnemySpawnRoutine());
		StartCoroutine(PowerUpSpawnRoutine());
	}
	
	IEnumerator EnemySpawnRoutine () {
		while(true) {
			Instantiate(enemyShipPrefab, new Vector3(Random.Range(-7f, 7f), 7, 0), Quaternion.identity);	
			yield return new WaitForSeconds(5.0f);
		}
	}
	
	IEnumerator PowerUpSpawnRoutine () {
		while(true) {
			Instantiate(powerUp);
			yield return new WaitForSeconds(30.0f);
		}
	}
}
