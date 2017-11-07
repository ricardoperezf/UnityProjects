using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			print ("Left arrow pressed");
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			print ("Right arrow pressed");
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow pressed");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow pressed");
		}
	}
}
