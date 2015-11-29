using UnityEngine;
using System.Collections;

public class LoadingController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (600, 500, 150, 40), "CONTINUE")) {
			Application.LoadLevel(3);
		}
	}
}
