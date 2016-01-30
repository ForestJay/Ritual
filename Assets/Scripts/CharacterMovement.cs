using UnityEngine;

public class CharacterMovement : MonoBehaviour {
	public float distanceToGround;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.GetComponent <Interact> ().hidden == false) {

			if (Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
				transform.Translate (-2 * Time.deltaTime, 0, 0); 

			}

			if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
				transform.Translate (2 * Time.deltaTime, 0, 0); 

			}

			if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
				transform.Translate (0, 0, 2 * Time.deltaTime); 

			}
			if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
				transform.Translate (0, 0, -2 * Time.deltaTime); 

			}

		}
	}
}
