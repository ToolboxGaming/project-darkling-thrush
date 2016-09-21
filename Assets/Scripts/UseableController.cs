using UnityEngine;
using System.Collections;

public class UseableController : MonoBehaviour {
	public float interactionRange;
	public GameObject hud;
	public int longPressTime;

	int useableLayerMask;
	IUseable target;
	float actionButtonDown;
	Component hudController;

	void Awake()
	{
		useableLayerMask = LayerMask.GetMask("Useable");
		hudController = hud.GetComponent<HudController>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray camRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		//Ray camRay = Camera.
		RaycastHit hit;

//		Debug.DrawRay(camRay.origin, camRay.direction, Color.green);

		if(Physics.Raycast(camRay, out hit, interactionRange, useableLayerMask)){
//			Debug.Log("Useable object!");
			target = hit.collider.GetComponent<IUseable>();
			//UI.promptAction(target.actionText);

			if(Input.GetButtonDown("Action")){
				actionButtonDown = Time.time;
			}
			else if(Input.GetButtonUp("Action")){
				if((Time.time - actionButtonDown) < longPressTime){
					target.use(this.gameObject);
				}
				else{
					target.useMenu(this.gameObject, hud);
				}
			}
		}
	}
}
