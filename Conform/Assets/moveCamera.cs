using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {
	public float setX = -5.56f;
	public float setY = 17f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (0.1f, 0f, 0f);
		if (GameObject.Find ("FMan (1)").transform.position.y <= setX && GameObject.Find ("Main Camera").transform.position.x < setY) {
			GameObject.Find ("Main Camera").transform.Translate (0.1f, 0f, 0f);
		}
	}
}
