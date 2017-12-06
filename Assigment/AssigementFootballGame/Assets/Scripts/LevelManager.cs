using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public void LoadLevel(string levelName)
	{
		print ("Loading Level" + levelName);
		SceneManager.LoadScene (levelName);
	}

	public void LoadNextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame()
	{
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
