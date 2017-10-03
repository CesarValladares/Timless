using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed; 
	public float jump;

	bool j = true;

	private Rigidbody rb;

	// Use this for initialization	
	void Start () {
		
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		transform.Translate (0, 0, x);

		if (j == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				rb.velocity += jump * Vector3.up;
				j = false;
			}
		}

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag("Ground"))
		{
			j = true;
		}
	}

}
