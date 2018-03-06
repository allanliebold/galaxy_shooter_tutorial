using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	private float _speed = 3.0f;
	
	void Update () {
		transform.Translate (Vector3.down * _speed * Time.deltaTime);	
	}
	
	private void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			Player player = other.GetComponent<Player>;
			if (player != null) {
				player.tripleShot = true;
			}
			startCoroutine(player.TripleShotTimer);
			
			Destroy(this.gameObject);
		}
	}
}

