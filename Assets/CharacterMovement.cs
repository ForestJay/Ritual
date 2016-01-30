using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	public float distanceToGround;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//	if (Physics.Raycast (transform.position, -Vector3.up, out hit)) {
	//		distanceToGround = hit.distance - transform.GetComponent<Collider> ().bounds.extents;
	//		transform.position.y = distanceToGround;
		if (this.gameObject.GetComponent <Interact> ().hidden == false) {

			if (Input.GetKey (KeyCode.A)) {
				transform.Translate (-2 * Time.deltaTime, 0, 0); 

			}

			if (Input.GetKey (KeyCode.D)) {
				transform.Translate (2 * Time.deltaTime, 0, 0); 

			}

			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (0, 0, 2 * Time.deltaTime); 

			}
			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (0, 0, -2 * Time.deltaTime); 

			}

		}
	}
}
