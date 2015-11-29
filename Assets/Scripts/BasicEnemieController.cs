using UnityEngine;
using System.Collections;

public class BasicEnemieController : MonoBehaviour {

	public float speed;
	public bool direction;
	public float directionDuration;
	private float directionTime;
	private Animator anime;

	// Use this for initialization
	void Start () {
		anime = gameObject.transform.GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () {

		if (direction) {
			transform.eulerAngles = new Vector2 (0, 0);
		} else {
			transform.eulerAngles = new Vector2 (0, -180);
		}
		transform.Translate (Vector2.right * speed * Time.deltaTime);

		directionTime += Time.deltaTime;
		if (directionTime >= directionDuration) {
			directionTime = 0;
			direction = !direction;
		}

	
	}
}
