using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;
using System.Linq;

public class VehicleController : MonoBehaviour, IUseable {
	public string _actionText;
	public string actionText 
	{
		get{ return _actionText; }
	}
	public float speedMax;
	public float acceleration;

	private GameObject player;
	private VehicleCameraController cameraController;
	private GameObject chair;
	private Rigidbody body;
	private float speed;

	void Start ()
	{
		body = this.gameObject.GetComponent<Rigidbody>();
		speed = body.velocity.magnitude;
//		chair = this.gameObject
//			.GetComponents<GameObject>()
//			.ToList<GameObject>()
//			.Where<GameObject>(x => x.ToString() == "Chair")
//			.First<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {}

	void FixedUpdate()
	{
		if(player == null)
		{
			return;
		}

		if(Input.GetButton("Action"))
		{
			use(player);
		}

		movement();
	}

	public void use(GameObject player)
	{
		Debug.Log("Vehicle use()");
		// No current driver
		if(this.player == null) {
			this.player = player;
			enterVehicle();
			takeControl();
		}
		else{
			exitVehicle();
			giveControl();
			this.player = null;
		}

	}

	public void useMenu(GameObject player, GameObject UI)
	{
		use(player);
	}

	void enterVehicle()
	{
		Vector3 chairPoint = Vector3.zero; //replace with chair later
		chairPoint.y += (player.GetComponent<Renderer>().bounds.size.y / 2);
		player.transform.parent = gameObject.transform;
		player.transform.localPosition = chairPoint;
		player.transform.localRotation = Quaternion.identity;
		player.GetComponent<Camera>().transform.localRotation = Quaternion.identity;
//		this.player.transform.position = this.gameObject.transform.position;
		// Move (or Lerp?) player to driver seat
	}

	void takeControl()
	{
		player.gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = false;
	}

	void exitVehicle()
	{
		player.transform.parent = null;
		// Move (or Lerp?) this player GameObject to exit point
		// Unparent player to self
	}

	void giveControl()
	{
		player.gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = true;
	}

	void movement()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		speed = Mathf.Min(speedMax, speed += acceleration);
		movement = movement.normalized * speed * Time.deltaTime;

		body.MovePosition(transform.position + movement);
	}
}
