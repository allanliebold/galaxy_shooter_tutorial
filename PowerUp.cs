using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	private float _speed = 3.0f;
	
	void Update () {
		transform.Translate (Vector3.down * _speed * Time.deltaTime);	
	}
	
	void OnTriggerEnter2D {
		
	}
}

