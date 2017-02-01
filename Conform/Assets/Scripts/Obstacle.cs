using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	public int id;

	private void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<FMan> () != null)
			GameControl.instance.Scored ();
	}

}
