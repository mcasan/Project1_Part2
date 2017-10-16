using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObject : MonoBehaviour {

	bool readyToPrint;

	// Use this for initialization
	void Start () {
		print ("the game has begun!");

		readyToPrint = true;
	}


	// Update is called once per frame
	void Update () {

		if (Time.time >= 3 && readyToPrint) {
			print ("It has been three seconds!");
			readyToPrint = false;
		}
	}
}