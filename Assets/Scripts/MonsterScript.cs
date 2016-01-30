using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {
	public float speed = 6.0F;
	public float gravity = 20.0F;
	public int sight = 5;
	private Vector3 moveDirection = Vector3.zero;

	private bool angered=false;

	public GameObject player;

	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray camerarayMiddle = new Ray (transform.position, transform.forward*sight);
		Ray camerarayTop = new Ray (transform.position+(transform.up), transform.forward * sight);
		Ray camerarayBottom = new Ray (transform.position+(transform.up*-1), transform.forward * sight);
		Ray camerarayLeft = new Ray (transform.position+(transform.right*-0.5f), transform.forward * sight);
		Ray camerarayRight = new Ray (transform.position+(transform.right*0.5f), transform.forward * sight);
		if (Physics.Raycast (camerarayMiddle, out hit, sight)||Physics.Raycast (camerarayTop, out hit, sight)||Physics.Raycast (camerarayBottom, out hit, sight)||Physics.Raycast (camerarayLeft, out hit, sight)||Physics.Raycast (camerarayRight, out hit, sight)) {
			if (hit.collider.tag == "Player") {
				angered = true;
			} else if (hit.collider.tag == "Wall"){
				transform.Rotate (Vector3.up * Time.deltaTime*80);
				angered = false;
			}

			Debug.DrawRay (camerarayMiddle.origin, camerarayMiddle.direction * hit.distance, Color.red);
			Debug.DrawRay (camerarayTop.origin, camerarayTop.direction * hit.distance, Color.red);
			Debug.DrawRay (camerarayBottom.origin, camerarayBottom.direction * hit.distance, Color.red);
			Debug.DrawRay (camerarayLeft.origin, camerarayLeft.direction * hit.distance, Color.red);
			Debug.DrawRay (camerarayRight.origin, camerarayRight.direction * hit.distance, Color.red);
		} else {
			
			Debug.DrawRay (camerarayMiddle.origin, camerarayMiddle.direction * sight, Color.green);
			Debug.DrawRay (camerarayTop.origin, camerarayTop.direction * sight, Color.green);
			Debug.DrawRay (camerarayBottom.origin, camerarayBottom.direction * sight, Color.green);
			Debug.DrawRay (camerarayLeft.origin, camerarayLeft.direction * sight, Color.green);
			Debug.DrawRay (camerarayRight.origin, camerarayRight.direction * sight, Color.green);
		}


		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			if (angered == true) {
				Vector3 target = player.transform.position;
				target.y = transform.position.y;
				transform.LookAt (target);
			} else {
				
			}

			moveDirection = new Vector3(0, 0, 1);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}
