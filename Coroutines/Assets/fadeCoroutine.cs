using UnityEngine;
using System.Collections;

public class fadeCoroutine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("waitAndPrint");

		if (Input.GetMouseButtonDown (0)) {
			//this is how the coroutine begins; 
//			StartCoroutine ("Fade");
		}
	}

	//return type of a coroutine is always an IEnumerator
	IEnumerator Fade() {

		for (float f = 1f; f >= 0; f -= 0.1f) {
			Color myColor = this.GetComponent<Renderer>().material.color;
			myColor.a = f;
			this.GetComponent<Renderer>().material.color = myColor;

			/*all coroutines ned to have a yeild function returing "null" 
			 * means that All Update functions have been called, 
			 * and are resumed on the next frame */
			yield return null;

//			yeild can also be used to control how frequently the coroutine is run: 
//			yield return new WaitForSeconds(1f);

		}

	}

	IEnumerator waitAndPrint(){ 
		yield return new WaitForSeconds(5);
		Debug.Log("It's been 5 seconds!");
	}
}
