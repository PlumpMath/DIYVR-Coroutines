using UnityEngine;
using System.Collections;

public class LerpCoroutineExample : MonoBehaviour {

	public Transform target; 
	// Use this for initialization
	void Start () {
		StartCoroutine ("TargetSpot", target); 
	}

	IEnumerator TargetSpot (Transform target){

		while(Vector3.Distance(transform.position, target.position) > 0.05f){

			//Lerp is a function which Linearly interpolates between two vectors.  
			//This is most commonly used to find a point some fraction of 
			//the way along a line between two endpoints 
			//(e.g. to move an object gradually between those points).

			transform.position = Vector3.Lerp(transform.position, target.position, 1f*Time.deltaTime); 
			//yeild return null so that coroutine can resume at the end of the next update
			yield return null; 
	}
			Debug.Log ("got there!"); 
			
			//this yeild reutnrs an instance of the waitforseconds class, effectively stalling the coroutine for 3 seconds
			yield return new WaitForSeconds(3f); 

		Debug.Log ("done with coroutine!");
	}
}
