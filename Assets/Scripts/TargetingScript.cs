using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingScript : MonoBehaviour {

	public Transform selectedTarget = null;
	void Update()
	{
		Ray viewRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit viewHit;
		if (Physics.Raycast (viewRay, out viewHit)) {
			Debug.Log (viewHit.collider.gameObject.name);
			if (viewHit.transform.gameObject.layer == 8) {
				Debug.Log ("Viewable hit");
			//	GUI.Label (new Rect (mousePos.x, mousePos.y - 100, 100, 20), "It's working");
			}
		}


		if (Input.GetMouseButtonDown (0)) { // when button clicked...
			Debug.Log ("Mouse clicked");
			Ray selectionRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			Debug.Log ("Raycast created");
			Debug.DrawRay (selectionRay.origin, selectionRay.direction * 10, Color.green);
			RaycastHit hit;
			Debug.Log ("RaycastHit created");
			if (Physics.Raycast (selectionRay, out hit)) {
				Debug.Log (hit.collider.gameObject.name);
				if (hit.transform.gameObject.layer == 8) {
					Debug.Log ("Selectable hit");
					DeselectTarget (); // deselect previous target (if any)...
					selectedTarget = hit.transform; // set the new one... 
					SelectTarget (); // and select it 
				}
			}
		}
	}

	private void SelectTarget()
	{
		//selectedTarget.renderer.material.color = Color.red; 
		Debug.Log ("Target Selected");
	}

	private void DeselectTarget(){
		if (selectedTarget){ // if any guy selected, deselect it 
			//selectedTarget.renderer.material.color = Color.blue; selectedTarget = null;
			Debug.Log("Target Deselected");
		} 
	} 
}

