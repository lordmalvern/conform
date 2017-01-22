using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour 
{
	private Rigidbody rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3 (GameControl.instance.scrollSpeed, 0);
	}

	void Update()
	{
		if(GameControl.instance.gameOver == true)
		{
			rb.velocity = Vector3.zero;
		}
	}
}