using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMesh : MonoBehaviour {

	private Rigidbody rb;
	public GameObject enemy;
	Renderer rend;
	public Material transparent; 
	public Material Notrans;
	Animator anim;
	bool tras = true; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () 
	{

		MeshRenderer m = enemy.GetComponent<MeshRenderer> ();
		BoxCollider b = enemy.GetComponent<BoxCollider> ();

		if (Input.GetKeyDown (KeyCode.Q))
		{
			if (tras == true) {
				b.enabled = false;
				tras = false; 
				Debug.Log ("Transparente");
				rend.sharedMaterial = transparent;
			} else if (tras == false) {
				b.enabled = true;
				tras = true; 
				Debug.Log ("Tangible");
				rend.sharedMaterial = Notrans;
			}
		}
	}
}
