using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squares : MonoBehaviour {

	private Rigidbody2D square;

	void Start () {
		square = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			square.velocity = new Vector2 (0f, 6f);
			
		} else if (Input.GetKey (KeyCode.S)) {

			square.velocity = new Vector2 (0f, -6f);
		} else {
			
			square.velocity = new Vector2 (0f, 0f);
		}
			
	}
}