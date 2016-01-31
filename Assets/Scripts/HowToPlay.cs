using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour {
	public GameObject panel;
	// Use this for initialization
	void Start () {
		panel = GameObject.Find ("PanelPlay");
		panel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ShowPanel(){
		panel.gameObject.SetActive (true);

	}
}
