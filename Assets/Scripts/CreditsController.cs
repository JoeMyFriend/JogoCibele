using UnityEngine;
using System.Collections;

public class CreditsController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onGUI(){
		if (GUI.Button (new Rect (600, 500, 100, 20), "BACK")) {
			Application.LoadLevel (0);
		}
	}

}
