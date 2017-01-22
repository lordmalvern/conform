using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("Lose Text").SetActive (false);
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
			print ("qweqweqwr");
			GameObject.Find ("Lose Text").SetActive (true);
			Time.timeScale = 0;
		}
	}
}
