
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

	public LevelManager myLevelManger;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Score.instance.ScoreAPoint ();
		Score.instance.ScoreTwoAPoint ();
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		myLevelManger.LoadLevel("Level3");

	}
	// Use this for initialization
	void Start () {

		myLevelManger = GameObject.FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update () {

	}
}
