using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController2 : MonoBehaviour {

	public GameObject platform; 

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{	
		MeshRenderer m = platform.GetComponent<MeshRenderer> ();
		BoxCollider b = platform.GetComponent<BoxCollider> ();

		if (Input.GetKeyDown (KeyCode.Q)) {
			m.enabled = false;
			b.enabled = false;
		}
	
		if (Input.GetKeyDown (KeyCode.E)) {
			m.enabled = true;
			b.enabled = true;
		}


	}
}
