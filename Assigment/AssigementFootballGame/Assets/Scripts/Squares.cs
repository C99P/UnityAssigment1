using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squares : MonoBehaviour {

	private Rigidbody2D square;


	// Use this for initialization
	void Start () {
		square = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			square.velocity = new Vector2 (0f, 5f);
			
		} else if (Input.GetKey (KeyCode.S)) {

			square.velocity = new Vector2 (0f, -5f);
		} else {
			
			square.velocity = new Vector2 (0f, 0f);
		}
			
	}
}