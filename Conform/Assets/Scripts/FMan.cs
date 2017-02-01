using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMan : MonoBehaviour {

	private bool isDead = false;
	private Rigidbody rb;
	public int health = 5;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (isDead == true) {
			print ("You are dead");


			Time.timeScale = 0;
		}

	}

	void OnCollisionEnter(Collision col)
	{
		rb.velocity = Vector3.zero;
		health -= 1;
		if (health == 0) {
			isDead = true;
			//GameControl games = GetComponent<GameControl>();
			//this.games.ManDown ();
			//GameObject.findGameControl.instance.ManDown ();
		}
		print (health);

	}
}
