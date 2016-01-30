using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 5.0f;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		if(gameObject.GetComponent<Interact>().hidden==false){
			controller.Move(moveDirection * Time.deltaTime);
		}
	}
}
