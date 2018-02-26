using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float speed = 5.0f;

	void Start () {
		transform.position = new Vector3 (0, 0, 0);
		Debug.Log (transform.position);
	}
	
	void Update () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");
		
		if(transform.position.x < 10) {
			transform.Translate (Vector3.right * speed * horizontalInput * Time.deltaTime);
			transform.Translate (Vector3.up * speed * verticalInput * Time.deltaTime);
		}
	}
}
