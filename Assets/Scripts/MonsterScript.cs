using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {
	public float speed = 4.0f;
	public float timeLeft = 2f;
	public GameObject stopPoint;
	public GameObject monster;
	public GameObject background;
	public GameObject monsterMusic;
	public GameObject cameraObject;

	//Animator anim;
	void Start()
	{
		//anim = GetComponent<Animator>();
		//anim.SetBool("downwards", true);
		stopPoint = GameObject.Find ("StopPoint");
		cameraObject = GameObject.FindGameObjectWithTag ("MainCamera");
		monster = GameObject.Find ("NewMonster");
		background = GameObject.Find ("Background");
		monsterMusic = GameObject.Find ("MonsterMusic");
	}



	//anim.SetBool("downwards", true);
	//anim.SetBool("left", true);
	//anim.SetBool("right", true);
    








	//used for the monster's line of sight

	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			background.GetComponent<Renderer> ().material.color = new Color (255, 255, 255);
			cameraObject.GetComponent<AudioSource> ().volume = 100.0f;
			monsterMusic.GetComponent<AudioSource> ().volume = 0.0f;
			Destroy (gameObject);
		}
		iTween.MoveTo (this.gameObject, stopPoint.transform.position, 40f);

}

}
