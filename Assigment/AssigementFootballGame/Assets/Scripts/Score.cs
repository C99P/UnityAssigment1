using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	//public static Score instance;
	public Text Scoree;

	public static int score = 0;
	public static int scoreTwo = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Scoree.text = score + "            " + scoreTwo;
	}
		
}
