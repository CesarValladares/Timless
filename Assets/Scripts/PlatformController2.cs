using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {
	
	public GameObject platform;


	// Use this for initialization
	void Start () 
	{
		MeshRenderer m = platform.GetComponent<MeshRenderer> ();
		BoxCollider b = platform.GetComponent<BoxCollider> ();

		m.enabled = false;
		b.enabled = false;
	}

	// Update is called once per frame
	void Update () 
	{	
		MeshRenderer m = platform.GetComponent<MeshRenderer> ();
		BoxCollider b = platform.GetComponent<BoxCollider> ();

		if (Input.GetKeyDown (KeyCode.Q)) {
			m.enabled = true;
			b.enabled = true;
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			m.enabled = false;
			b.enabled = false;
		}


	}
}
