using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {
	public float speed = 4.0f;
	//normal speed
	public float maxSpeed=8.0f;
	//speed for chasing the player
	public float gravity = 20.0F;
	public int sight = 5;
	//how far the monster can see
	private Vector3 moveDirection = Vector3.zero;

	[SerializeField]
	private bool angered=false;

	public GameObject player;

	RaycastHit hit;

	//used for the monster's line of sight

	
	// Update is called once per frame
	void Update () {
		
		Ray camerarayMiddle = new Ray (transform.position, transform.forward*sight);
		Ray camerarayTop = new Ray (transform.position+(transform.up), transform.forward * sight);
		Ray camerarayBottom = new Ray (transform.position+(transform.up*-1), transform.forward * sight);
		Ray camerarayLeft = new Ray (transform.position+(transform.right*-0.5f), transform.forward * sight);
		Ray camerarayRight = new Ray (transform.position+(transform.right*0.5f), transform.forward * sight);
		if (Physics.Raycast (camerarayMiddle, out hit, sight)||Physics.Raycast (camerarayTop, out hit, sight)||Physics.Raycast (camerarayBottom, out hit, sight)||Physics.Raycast (camerarayLeft, out hit, sight)||Physics.Raycast (camerarayRight, out hit, sight)) {
			if (hit.collider.tag == "Player" && hit.collider.GetComponent<Interact>().hidden==false) {
				angered = true;


				Debug.DrawRay (camerarayMiddle.origin, camerarayMiddle.direction * hit.distance, Color.red);
				Debug.DrawRay (camerarayTop.origin, camerarayTop.direction * hit.distance, Color.red);
				Debug.DrawRay (camerarayBottom.origin, camerarayBottom.direction * hit.distance, Color.red);
				Debug.DrawRay (camerarayLeft.origin, camerarayLeft.direction * hit.distance, Color.red);
				Debug.DrawRay (camerarayRight.origin, camerarayRight.direction * hit.distance, Color.red);
				//draw rays for testing purposes

			}else if (hit.collider.tag == "Wall"||hit.collider.tag == "Bush"){

					transform.Rotate (Vector3.up * Time.deltaTime * 100);
					//turn right when at a wall

				angered = false;


				Debug.DrawRay (camerarayMiddle.origin, camerarayMiddle.direction * sight, Color.blue);
				Debug.DrawRay (camerarayTop.origin, camerarayTop.direction * sight, Color.blue);
				Debug.DrawRay (camerarayBottom.origin, camerarayBottom.direction * sight, Color.blue);
				Debug.DrawRay (camerarayLeft.origin, camerarayLeft.direction * sight, Color.blue);
				Debug.DrawRay (camerarayRight.origin, camerarayRight.direction * sight, Color.blue);
				//draw rays for testing purposes
			}else{
				
				Debug.DrawRay (camerarayMiddle.origin, camerarayMiddle.direction * sight, Color.yellow);
				Debug.DrawRay (camerarayTop.origin, camerarayTop.direction * sight, Color.yellow);
				Debug.DrawRay (camerarayBottom.origin, camerarayBottom.direction * sight, Color.yellow);
				Debug.DrawRay (camerarayLeft.origin, camerarayLeft.direction * sight, Color.yellow);
				Debug.DrawRay (camerarayRight.origin, camerarayRight.direction * sight, Color.yellow);
				//draw rays for testing purposes
			}


		} else {

			Debug.DrawRay (camerarayMiddle.origin, camerarayMiddle.direction * sight, Color.green);
			Debug.DrawRay (camerarayTop.origin, camerarayTop.direction * sight, Color.green);
			Debug.DrawRay (camerarayBottom.origin, camerarayBottom.direction * sight, Color.green);
			Debug.DrawRay (camerarayLeft.origin, camerarayLeft.direction * sight, Color.green);
			Debug.DrawRay (camerarayRight.origin, camerarayRight.direction * sight, Color.green);
			//draw rays for testing purposes
		}


		CharacterController controller = GetComponent<CharacterController>();
		if (angered == true) {
			Vector3 target = player.transform.position;
			target.y = transform.position.y;
			transform.LookAt (target);
			//look at player for chase
		}
		if (controller.isGrounded) {
			
			moveDirection = new Vector3(0, 0, 1);
			moveDirection = transform.TransformDirection(moveDirection);
			if (angered == false) {
				moveDirection *= speed;
			} else {
				moveDirection *= maxSpeed;
			}


		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}
