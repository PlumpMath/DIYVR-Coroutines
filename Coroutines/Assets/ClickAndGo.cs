using UnityEngine;
using System.Collections;

public class ClickAndGo : MonoBehaviour {

	public PropertyCoroutineExample theCoroutineScript;
	Ray ray; 

	void Update(){
		//		Ray ray = Camera.main.ScreenPointToRay (new Vector3(OnMouseDown));
		ray = Camera.main.ViewportPointToRay (new Vector3(0.5F, 0.5F, 0));
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
		if (Input.GetMouseButtonDown(0)){
		RaycastHit hit; 
		Physics.Raycast (ray, out hit); 
		//setting the target
		theCoroutineScript.Target = hit.point; 
		}
	}

}
