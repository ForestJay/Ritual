using UnityEngine;
using System.Collections;

public class FriendScript : MonoBehaviour {

	public static float friendHealth = 100.0f;
	public static float time = 0.0f;
	public static int day = 0;
	private float actualhealth=1.0f;
	private float distance;

	public Texture2D bgImage;

	public Texture2D fgImage;

	public GameObject player;
	public GameObject sun;


	void Start(){
		
	}
	
	// Update is called once per frame
	void Update () {
		if (friendHealth > 100) {
			friendHealth = 100;
		}

		distance = Vector3.Distance (transform.position, player.transform.position)/10;
		friendHealth = friendHealth - 0.1f * Time.deltaTime;
		actualhealth = friendHealth / 100;
		time = time + 0.5f * Time.deltaTime;
		sun.transform.rotation = Quaternion.Euler(time-10,0,0);

		if (time > 222.0f) {
			print ("you won ya nerd");
			if (day == 0) {
				time = 0;
				day++;
				//go to next level
			}
			if (day == 1) {
				time = 0;
				day++;
				//go to next level
			}
			if (day == 2) {
				time = 0;
				day++;
				//go to next level
			}
			if (day == 3) {
				time = 0;
				day++;
				//go to next level
			}
			if (day == 4) {
				time = 0;
				day++;
				//Should be impossible to get to this point, but if we change our minds, this is the win condition
			}

		}

		if (friendHealth <= 0.0f) {
			print ("ya lost! Get gud, scrub!");
			//go to game over screen
		}
	
	}

	void OnGUI(){
		GUI.color = new Color (1.0f,1.0f,1.0f,1-distance);
		GUI.BeginGroup (new Rect (0, 0, 256, 32), bgImage);

		GUI.BeginGroup (new Rect (0, 0, actualhealth*256, 32), fgImage);

		GUI.EndGroup ();

		GUI.EndGroup();
		GUI.color = Color.white;
	}
}
