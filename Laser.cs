using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	
	public float speed = 10.0f;

	void Start () {
		
	}
	
	void Update () {
		transform.Translate(Vector3.up * speed * Time.deltaTime);
		
		if(transform.y > 6) {
			// destroy game object	
		}
	}
}

