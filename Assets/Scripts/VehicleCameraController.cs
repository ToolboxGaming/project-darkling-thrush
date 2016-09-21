using UnityEngine;
using System.Collections;
using System;

public class VehicleCameraController : MonoBehaviour {
	public float speedMax;
	public float acceleration;
	public Camera camera;

	private Rigidbody body;
	private float speed;

	void Start ()
	{
		body = this.gameObject.GetComponent<Rigidbody>();
		speed = body.velocity.magnitude;
	}

	void onEnable()
	{
		camera.enabled = true;
	}

	void onDisable()
	{
		camera.enabled = false;
	}
	
	// Update is called once per frame
	void Update(){}
}
