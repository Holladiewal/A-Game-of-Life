using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	public Vector2 movef;
	public Vector2 moveb;
	public Vector2 movel;
	public Vector2 mover;
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetAxis("Vertical") > 0){rb.position = rb.position + movef * Time.deltaTime;}
		if ( Input.GetAxis("Vertical") < 0){rb.position = rb.position + moveb * Time.deltaTime;}
		if ( Input.GetAxis("Horizontal") < 0){rb.position = rb.position + movel * Time.deltaTime;}
		if ( Input.GetAxis("Horizontal") > 0){rb.position = rb.position + mover * Time.deltaTime;}

	}
}
