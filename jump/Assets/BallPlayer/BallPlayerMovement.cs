using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlayerMovement : MonoBehaviour 
{
	public Rigidbody rb;

	public float speed;
	public float jumpSpeed;

	Collision col;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float Straight = Input.GetAxis ("Vertical");
		float Straffe = Input.GetAxis ("Horizontal");

		Vector3 Movement = new Vector3 (Straight, 0, Straffe);
		Vector3 jump = new Vector3 (0, jumpSpeed, 0);

		GetComponent<Rigidbody>().AddForce (Movement * speed * Time.deltaTime);

		 

		if (Input.GetButtonDown ("Jump"))
		{
			GetComponent<Rigidbody> ().AddForce (jump * jumpSpeed * Time.deltaTime);
		}

	}


}
