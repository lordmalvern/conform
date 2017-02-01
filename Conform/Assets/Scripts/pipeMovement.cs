using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class pipeMovement : MonoBehaviour {

	float prevKnob = 0;
	float prevvKnob = 0;
	int knob = 0;
	public int knobValue = 80;
	public float pos;
	public Rigidbody rbody;
	float moveY = 0 ;
	public string pipe = "Obstacle";
	// Use this for initialization

	void Awake(){
		pos = GameObject.Find(pipe).transform.position.y;
		rbody = GetComponent<Rigidbody>();
	}


	void Start () {
		print ("Game Start");	
	}

	int checkKnobTurn(int inc){
		if (MidiMaster.GetKnob (inc) != prevKnob) {
			prevKnob = MidiMaster.GetKnob (inc);
			return (inc);
		}
		return -1;
	}


	// Update is called once per frame
	void Update () {
		knob = checkKnobTurn (knobValue);
		if (knob != -1) {
			//print ("Velocity:" + MidiMaster.GetKnob (knob).ToString () + ", keyPressed:" + (knob).ToString ());
			float speed = 0;
			//print (prevvKnob - prevKnob);
			if (prevvKnob - prevKnob < 0) {
				speed = 1;
			} else {
				speed = - 1;
			}
			//print (prevvKnob - prevKnob);
		 	moveY =  speed * 10000 *  Time.deltaTime;

		
		}
		rbody.AddForce (0f, moveY * Time.deltaTime, 0f);
		//print (GameObject.Find ("Cylinder").transform.position.y);
		//print(prevKnob);
		prevvKnob = prevKnob;

		//float inputXX = Input.GetAxis("Vertical");
		//float inputY = Input.GetAxis("Horizontal");
		//float moveY = -inputY * Time.deltaTime;
		//float moveXX = inputXX * Time.deltaTime;
		//rbody.AddForce (moveY, moveXX, 0f);


	}
}