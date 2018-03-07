using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	[SerializedField]
	private float _speed = 3.0f;
	[SerializedField]
	private int powerUpID;
	
	void Update () {
		transform.Translate (Vector3.down * _speed * Time.deltaTime);	
	}
	
	private void OnTriggerEnter2D (Collider2D other) {
		if (this.tag = "TripleShot" and other.tag == "Player") {
			Player player = other.GetComponent<Player>();
			if (player != null) {
				player.TripleShotOn();
			}
			
		if (this.tag = "SpeedUp" and other.tag == "Player") {
			// Speed Up power up 	
		}
			Destroy(this.gameObject);
		}
	}
}

