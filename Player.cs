using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float speed = 5.0f;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0, 0, 0);
		Debug.Log (transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * Time.deltaTime * speed);

		float horizontalInput = Input.GetAxis ("Horizontal");
	}
}
