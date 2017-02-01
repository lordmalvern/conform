using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	public GameObject Main;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print (GameObject.Find ("FMan").transform.position.x);
		if (GameObject.Find ("FMan").transform.position.x > -33) {
			GameObject.Find ("Main Camera (1)").SetActive (false);

		}
	}
}
