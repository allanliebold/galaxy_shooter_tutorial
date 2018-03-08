using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField]
	private GameObject _laserPrefab;
	[SerializedField]
	private Gameobject _tripleShotPrefab;
	
	[SerializeField]
	private float _fireRate = 0.25f;
	private float _canFire = 0.5f;
	
	[SerializeField]
	private float _speed = 5.0f;
	
	public bool tripleShot = false;
	public bool speedBoost = false;
	public bool shield = false;

	private void Start () {
		transform.position = new Vector3 (0, 0, 0);
		Debug.Log (transform.position);
	}
	
	private void Update () {
		Movement ();
		
		if(Input.GetButtonDown("Fire1")) {
			Shoot ();
		}
	}
	
	private void Shoot () {
		if(Time.time > _canFire) {
			if(tripleShot) {
				Instantiate(_laserPrefab, transform.position, Quaternion.identity);
			} else {
				Instantiate(_laserPrefab, transform.position + new Vector3(0, 0.88f, 0), Quaternion.identity);
			}
			_canFire = Time.time + _fireRate;
		}	
	}
	
	private void Movement () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");
		
		transform.Translate (Vector3.right * _speed * horizontalInput * Time.deltaTime);
		transform.Translate (Vector3.up * _speed * verticalInput * Time.deltaTime);
		
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
	
	public void TripleShotOn () {
		tripleShot = true;
		StartCoroutine(PowerUpTimer());
	}
	
	public void SpeedBoostOn () {
		speedBoost = true;
		StartCoroutine(PowerUpTimer());
	}
	
	public void ShieldOn () {
		shield = true;
	}
	
	public IEnumerator PowerUpTimer () {
		yield return new WaitForSeconds(5.0f);
		if(tripleShot) {
			tripleShot = false;
		}
	}
}
