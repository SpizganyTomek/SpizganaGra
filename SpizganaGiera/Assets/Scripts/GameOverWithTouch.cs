using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverWithTouch : MonoBehaviour
{
	[SerializeField] private GameObject gameOverCanvas = null;

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			Time.timeScale = 0;
			gameOverCanvas.SetActive(true);
			coll.gameObject.GetComponent<Player>().Dead();
		}		
	}
}
