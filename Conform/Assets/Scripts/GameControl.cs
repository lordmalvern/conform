using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public Text scoreText;
	public GameObject gameOvertext;

 	private int score = 0;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	public void Scored() {
		score++;
		scoreText.text = "Score: " + score.ToString();
	}
	
	void Update () {
		print ("qqqqq");
	}

	public void ManDown() {
		print ("Asd");
		gameOver = true;
	}

}
