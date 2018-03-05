using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	private float _speed = 0.5f;

	void Start () {
		
	}
	
	void Update () {
		transform.Translate (Vector3.down * Time.deltaTime);	
	}
}

