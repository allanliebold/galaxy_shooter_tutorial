using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	
	public float speed = 10.0f;

	void Start () {
		
	}
	
	void Update () {
		// move up at speed 10
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}
}

