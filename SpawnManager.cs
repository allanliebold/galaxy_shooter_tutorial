using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	
	private float spawnTimer = 4.0f;
	
	[SerializedField]
	private GameObject _enemy;
	[SerializedField]
	private GameObject _powerUp;
	
	void Update () {
		
	}
	
	void SpawnEnemy () {
		// Instantiate new enemy
	}
	
	void SpawnPowerUp () {
		// Instantiate power up. Timer or based on number of enemies destroyed? 	
	}
}
