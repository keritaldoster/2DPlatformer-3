﻿using UnityEngine;
using System.Collections;

public class CatControllerScript : MonoBehaviour {

	public float maxSpeed = 10f;
	private bool facingRight = true;
	private Animator anim;
	private bool grounded = false;
	public Transform groundCheck;
	private float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700;
	private bool doubleJump = false;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		anim.SetBool ("Ground", grounded);

		if (grounded)
			doubleJump = false;

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		//if (!grounded)
		//	return;
	
		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update()
	{
		if ((grounded || !doubleJump) && Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			anim.SetBool ("Ground", false);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));

			if(!doubleJump && !grounded)
				doubleJump = true;
		}


	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
