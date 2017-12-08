using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

	public static Score instance;

	public Text scoreText;
	public Text scoreTwoText;

	public int score;
	public int scoreTwo;

	// Use this for initialization
	void Start () {

		instance = this;
		score = scoreTwo = 0;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void ScoreAPoint(){
		
		score += 1;
		scoreText.text = score.ToString ();
	}

	public void ScoreTwoAPoint(){
		
		scoreTwo += 1;
		scoreTwoText.text = scoreTwo.ToString ();
	}
}
