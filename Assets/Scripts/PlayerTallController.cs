using UnityEngine;
using System.Collections;

public class PlayerTallController : MonoBehaviour {

	public Rigidbody2D 	playerRigidbody;
	public Animator		Anime;
	public int			forceJump;
	public int			forceWalk;
	public float		maxSpeed;
	/*public bool			howl;
	public float		howlTemp;
	public float		howlTimeTemp;*/
	public Transform	GroundCheck;
	public bool			grounded;
	public LayerMask	whatIsGround;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(((Input.GetAxisRaw("Horizontal") > 0) && grounded)) {
			playerRigidbody.velocity = new Vector2 (forceWalk * maxSpeed, playerRigidbody.velocity.y);
			}
			/*walk = true;*/

		if (Input.GetButtonDown ("Jump") && grounded == true) {
			playerRigidbody.AddForce(new Vector2(0, forceJump));
			/*howl = false;*/	
		}
		
		/*if (Input.GetButtonDown ("Special") && grounded == true) {
			howl = true;
			howlTimeTemp = 0;
		}*/
		
		grounded = Physics2D.OverlapCircle (GroundCheck.position, 0.2f, whatIsGround);
		
		/*if (howl = true) {
			howlTimeTemp += Time.deltaTime;
			if(howlTimeTemp >= howlTemp){
				howl = false;
			}
		}
		
		Anime.SetBool ("Jump", !grounded);
		Anime.SetBool ("Howl", howl);*/
	}
}
