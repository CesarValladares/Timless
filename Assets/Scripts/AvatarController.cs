using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour {

	public float speed; 
	public float jump;

	private Rigidbody rb;

	bool j = true;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
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
			}
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Ground"))
		{
			j = true;
			Debug.Log (j);
		}	
	}
}
