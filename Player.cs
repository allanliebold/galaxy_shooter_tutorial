using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private GameObject laserPrefab;
	
	[SerializeField]
	private float _fireRate = 0.25f;
	private float _canFire = 0.5f;
	
	[SerializeField]
	private float _speed = 5.0f;

	private void Start () {
		transform.position = new Vector3 (0, 0, 0);
		Debug.Log (transform.position);
	}
	
	private void Update () {
		Movement ();
		
		if(Input.GetButtonDown("Fire1")) {
			if(Time.time > canFire) {
				Instantiate(laserPrefab, transform.position + new Vector3(0, 0.88f, 0), Quaternion.identity);
				canFire = Time.time + fireRate;
			}
		}
	}
	
	private void Movement () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");
		
		transform.Translate (Vector3.right * speed * horizontalInput * Time.deltaTime);
		transform.Translate (Vector3.up * speed * verticalInput * Time.deltaTime);
		
		if(transform.position.x > 9.4f) {
			transform.position = new Vector3(9.4f, transform.position.y, 0);	
		} else if(transform.position.x < -9.4f) {
			transform.position = new Vector3(-9.4f, transform.position.y, 0);	
		}		
/* To have the player wrap around horizontally
	if(transform.position.x > 9.4f) {
		transform.position = new Vector3(-9.4f, transform.position.y, 0);
	} else if(transform.position.x < -9.4f) {
		transform.position = new Vector3(9.4f, transform.position.y, 0);
	}
*/
		if(transform.position.y > 0) {
			transform.position = new Vector3(transform.position.x, 0, 0);
		} else if(transform.position.y < -4.2f) {
			transform.position = new Vector3(transform.position.x, -4.2f, 0);
		}	
	}
	
}
