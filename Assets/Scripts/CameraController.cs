using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	public Vector3 Offset;

	// Use this for initialization
	void Start () 
	{
		Offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void Update ()
	{
		transform.position = player.transform.position + Offset;
	}
}
