using UnityEngine;

public class Player2D : MonoBehaviour {

	public float speed = 6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// FixedUpdate is called one per specific time
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 				//Get if Any Horizontal Keys pressed
		float moveVertical = Input.GetAxis ("Vertical");					//Get if Any Vertical Keys pressed
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical); 		//Put them in a Vector2 Variable (x,y
		GetComponent<Rigidbody2D> ().velocity = movement * speed; 							//Add Velocity to the player ship rigidbody

	}

}
