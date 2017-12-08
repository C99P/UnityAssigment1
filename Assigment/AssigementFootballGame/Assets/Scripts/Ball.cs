using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Squares mySquare;

	float randomX, randomY;

	private Vector3 squareToBallVector;

	bool hassStarted = false;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		randomX = Random.Range (0f, 0.2f);
		randomY = Random.Range (0f, 0.2f);

		//creating a vector 2 tweek with a randomx and randomy
		Vector2 tweak = new Vector2 (randomX, randomY);

		if (hassStarted) {
			this.GetComponent<Rigidbody2D>().velocity += tweak;
		}
	}

	// Use this for initialization
	void Start () {
		//searches for object type square and assigns it to my square
		mySquare = GameObject.FindObjectOfType<Squares>();

		//saves the distance between the ball and the paddle
		squareToBallVector = this.transform.position - mySquare.transform.position;
	}

	// Update is called once per frame
	void Update () {
		this.transform.rotation = new Quaternion (0f, 0f, 0f, 0f);

		if (!hassStarted) {

			//move the ball with the square keeping the distance
			this.transform.position = mySquare.transform.position + squareToBallVector;

			if (Input.GetMouseButtonDown (0)) {
				print ("Left Click");
				hassStarted = true;

				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
			}

		}
	}
}
