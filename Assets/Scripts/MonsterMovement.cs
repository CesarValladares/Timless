using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour {

	public float speed; 
	private Rigidbody rb;
	public GameObject enemy;
	private GameObject player; 
	Renderer rend;
	Animator anim;
	float timeleft = 6.6f;
	bool tras = true; 
	public Transform Player;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		float posp = player.transform.position.x;
		float posm = transform.position.x;

		var x = Time.deltaTime * speed;

		if (Input.GetKeyDown (KeyCode.Q)) {
			if (tras == true) {tras = false;} else if (tras == false) {tras = true;}
		}

		if (tras == true) {//visible

			transform.Translate (0, 0, x);

			if (posp > posm) {
				GetComponent<Transform> ().eulerAngles = new Vector3 (0, 90, 0);
			} else {
				GetComponent<Transform> ().eulerAngles = new Vector3 (0, 270, 0);
			}
		} else if (tras == false) {//Transparent

			transform.Translate (0, 0, x);


		}

		timeleft -= Time.deltaTime;

		Debug.Log ("posicion monstruo = " + transform.position.x);
		Debug.Log ("posicion jugador = " + posp);

		/*if (timeleft < 0) {

			enemy.SetActive (false);
		}*/

	}
}
