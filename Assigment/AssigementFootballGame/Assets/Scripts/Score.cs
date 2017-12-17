using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	public Text Scoree;

	public static int score = 0;
	public static int scoreTwo = 0;

	void Start () {

	}
	//Setting the Score text
	void Update () {
		Scoree.text = score + "            " + scoreTwo;

		Points ();
	}
	//Moving to another level at certin score
	public static void Points (){
		Scene activeScene = SceneManager.GetActiveScene ();
		string myScene = activeScene.name;

		if (myScene == "Level1" & score == 5) {
			SceneManager.LoadScene ("Level2");

		} else if (myScene == "Level1" & scoreTwo == 5) {
			SceneManager.LoadScene ("Level2");

		} else if (myScene == "Level2" & score == 15) {
			SceneManager.LoadScene ("Level3");

		} else if (myScene == "Level2" & scoreTwo == 15) {
			SceneManager.LoadScene ("Level3");

		} else if (myScene == "Level3" & score == 25) {
			SceneManager.LoadScene ("EndingScrene");

		} else if (myScene == "Level3" & scoreTwo == 25) {
			SceneManager.LoadScene ("EndingScrene");
		}
	}
}
