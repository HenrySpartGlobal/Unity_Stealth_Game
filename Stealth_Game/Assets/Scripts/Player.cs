using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed = 7;
	public float smoothMoveTime = .1f;
	public float turnSpeed = 8;

	float angle;
	float smoothInputPressed;
	float smoothMoveVelocity;
	Vector3 velocity;

	Rigidbody skeleton;

	void Start() {
		skeleton = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		//movement of player, "GetAxisRaw" makes the movement smoother
		Vector3 inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
		//only move when there is an input
		float inputPressed = inputDirection.magnitude;
		//smooths the players movement, "ref" allows me to change the variable of smoothMoveVelocity on the fly
		smoothInputPressed = Mathf.SmoothDamp(smoothInputPressed, inputPressed, ref smoothMoveVelocity, smoothMoveTime);
		//direction player is facing
		float targetAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg;
		//controls angle smoothing
		angle = Mathf.LerpAngle(angle, targetAngle, Time.deltaTime * turnSpeed * inputPressed);

		velocity = transform.forward * moveSpeed * smoothInputPressed;
	}

	void FixedUpdate(){
		skeleton.MoveRotation(Quaternion.Euler(Vector3.up * angle));
		skeleton.MovePosition(skeleton.position + velocity * Time.deltaTime);
	}
}
