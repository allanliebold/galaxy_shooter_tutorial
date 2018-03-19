using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	[SerializedField]
	private float _speed = 3.0f;
	[SerializedField]
	private int powerUpID; // 0 = Triple Shot, 1 = Speed Boost, 2 = Shield, 3 = Rapid Fire
	// Other ideas for powerups - heavy laser (wide and shoots through multiple enemies)
	// invincibility? Different from shield
	
	void Update () {
		transform.Translate (Vector3.down * _speed * Time.deltaTime);	
	}
	
	private void OnTriggerEnter2D (Collider2D other) {
		if (this.tag = "TripleShot" and other.tag == "Player") {
			Player player = other.GetComponent<Player>();
			if (player != null) {
				if(powerUpID == 0) {
					player.TripleShotOn();
				}
				if(powerUpID == 1) {
					player.SpeedBoostOn();	
				}
				if(powerUpID == 2) {
					player.ShieldOn();
//				}
//				if(powerUpID == 3) {
//					player.RapidFireOn();
				}
				// player shouldn't be able to have multiple active power ups at the same time
				// maybe shield is allowed along with another, since it's not on a timer. 
				// would it override? Or I guess since the power ups are spread out it doesn't matter. 
			}
			Destroy(this.gameObject);
		}
	}
}

