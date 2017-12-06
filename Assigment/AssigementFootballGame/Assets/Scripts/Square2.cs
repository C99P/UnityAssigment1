using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInBlocks = (Input.mousePosition.y / Screen.width * 10f) - 3.5f;

		//Vector 3 saves any point in xyz
		Vector3 paddlePosition = new Vector3 (5.62f, this.transform.position.y, -1f);

		paddlePosition.y = Mathf.Clamp(mousePosInBlocks, -3.5f, 3.5f);
		//sets the position of the paddle (this) to
		//the paddlePosition
		this.transform.position = paddlePosition;
	}
}
