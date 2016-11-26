using UnityEngine;
using System.Collections;

public class PropertyCoroutineExample : MonoBehaviour {

	public Vector3 Target
	{
		get { return thetarget; }

		//when we allocate to the target object, we call the set function
		set 
		{
			thetarget = value; 

	
			StopCoroutine ("Movement");
			StartCoroutine ("Movement", thetarget); 
		}
	}

	private Vector3 thetarget; 

	IEnumerator Movement (Vector3 target)
	{
		while (Vector3.Distance(transform.position, target) >0.05f){
			transform.position = Vector3.Lerp(transform.position, target, 1f*Time.deltaTime); 
			yield return null; 
		}
	}
}
