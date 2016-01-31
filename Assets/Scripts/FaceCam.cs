using UnityEngine;
public class FaceCam : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Camera.main.transform.position, -Vector3.up);
	}
}
