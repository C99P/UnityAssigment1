using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Won : MonoBehaviour {

	public Text Win;

	public static int score = 0;
	public static int scoreTwo = 0;

	// Use this for initialization
	void Start () {
		Win.text = score + "  " + scoreTwo;
	}

	// Update is called once per frame
	void Update () {

		if (score == 25) {
			Win.text = "Player 1 Won!"; 

		} else if (scoreTwo == 25) {
			Win.text = "Player 2 Won!";

		}
	}
}
