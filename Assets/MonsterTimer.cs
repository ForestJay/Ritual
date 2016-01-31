using UnityEngine;
using System.Collections;

public class MonsterTimer : MonoBehaviour {
	float timeLeft = 25f;
	public GameObject monster;
	public GameObject background;
	public GameObject monsterMusic;
	public GameObject cameraObject;
	// Use this for initialization
	void Start () {
		cameraObject = GameObject.FindGameObjectWithTag ("MainCamera");
		monster = GameObject.Find ("NewMonster");
		background = GameObject.Find ("Background");
		monsterMusic = GameObject.Find ("MonsterMusic");
		monsterMusic.GetComponent<AudioSource> ().volume = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )	{
			monster = Instantiate (Resources.Load("Monster"), transform.position, transform.rotation) as GameObject;
				background.GetComponent<Renderer> ().material.color = new Color(0,0,0);
			cameraObject.GetComponent<AudioSource> ().volume = 0.0f;
			monsterMusic.GetComponent<AudioSource> ().volume = 100.0f;
			timeLeft = 25f;
		}
	}

}
