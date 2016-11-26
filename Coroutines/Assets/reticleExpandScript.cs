using UnityEngine;
using System.Collections;

public class reticleExpandScript : MonoBehaviour {

	// Use this for initialization
	Ray ray; 
	Vector3 scaledUp;
	Vector3 scaledDown; 

	void Start () {
		scaledUp = new Vector3(2,2,2); 
		scaledDown = new Vector3(1,1,1); 

	}

	// Update is called once per frame
	void Update () {
		ray = Camera.main.ViewportPointToRay (new Vector3 (0.5F, 0.5F, 0));
		Debug.DrawRay (ray.origin, ray.direction * 10, Color.blue);
		RaycastHit hit; 
		if (Physics.Raycast (ray, out hit)) {
			if (hit.transform.tag == "Interactive") {	
				Debug.Log ("hit"); 
				this.transform.localScale = scaledUp;
			} 
			if (hit.transform.tag != "Interactive") {	
				Debug.Log ("hit"); 
				this.transform.localScale = scaledDown;
				} 
			}
		else {
			this.transform.localScale = scaledDown;
		} 
	}
}
