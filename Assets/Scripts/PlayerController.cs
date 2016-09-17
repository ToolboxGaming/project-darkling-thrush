using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed = 6f;

	Vector3 movement;
	Rigidbody playerRigidbody;


	// Use this for initialization
	void Start() 
	{
		playerRigidbody = GetComponent<Rigidbody>();
	}

	// FixedUpdate is called once per frame before physics happens
	void FixedUpdate()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
	}
	
	// Update is called once per frame
	void Update() 
	{
	
	}

	void move(float h, float v)
	{
		movement.Set(h/2, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;

		playerRigidbody.MovePosition(transform.position + movement);
	}

	void setFace(float x, float y)
	{
		
	}
}
