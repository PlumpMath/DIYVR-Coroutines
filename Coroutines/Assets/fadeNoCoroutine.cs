using UnityEngine;
using System.Collections;

public class fadeNoCoroutine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		without using a coroutine, the whole fade will attempt to happen in one frame! 
		if (Input.GetMouseButtonDown (0)) {
			Fade (); 
		}
	}

	void Fade() {
		for (float f = 1f; f >= 0; f -= 0.1f) {
			Color myColor = this.GetComponent<Renderer>().material.color;
			myColor.a = f;
			this.GetComponent<Renderer>().material.color = myColor;
		}
	}

}
