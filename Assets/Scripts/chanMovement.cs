using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chanMovement : MonoBehaviour {

	public float speed; 
	public float jump;

	public GameObject player;

	Animator anim;
	int jumpHash = Animator.StringToHash ("jump");
	int groundHash = Animator.StringToHash ("ground");

	bool j = true;

	private Rigidbody rb;

	// Use this for initialization	
	void Start () {

		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		var horizontal = Input.GetAxis ("Horizontal");

		//rotate depending on the direction 
		if (Input.GetKey(KeyCode.A))
		{
			GetComponent<Transform> ().eulerAngles = new Vector3 (0, 270, 0);
			horizontal = horizontal * -1;
		}


		if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Transform> ().eulerAngles = new Vector3 (0, 90, 0);
			var horizontal2 = Input.GetAxis ("Horizontal");
			horizontal = horizontal2; 
		}

		//move only horizontal

		var x = horizontal * Time.deltaTime * speed;
		transform.Translate (0, 0, x);

		//jump 
		if (j == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				rb.velocity += jump * Vector3.up;
				j = false;
				anim.SetTrigger(jumpHash);
			}
		}
		anim.SetFloat ("speed", horizontal);
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Ground"))
		{
			j = true;
			anim.SetTrigger (groundHash);
		}	

		if (other.gameObject.CompareTag ("enemy")) 
		{
			Debug.Log ("te atrapo");
			player.SetActive (false);
		}

	}

}
