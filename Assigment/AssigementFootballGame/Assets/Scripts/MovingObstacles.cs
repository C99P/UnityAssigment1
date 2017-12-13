using System.Collections;
using UnityEngine;

public class MovingObstacles : MonoBehaviour {
	public Transform start;
	private Vector3 obs;
	private Vector3 obs2;
	private float timeLenght = 8f;

	void Start()
	{
		obs = transform.position;
		obs2 = start.position;
	}

	void Update()
	{
		transform.position = Vector3.Lerp(obs, obs2,
			Mathf.SmoothStep(0f,1f,
				Mathf.PingPong(Time.time/timeLenght, 1f)
			) );
	}
}

