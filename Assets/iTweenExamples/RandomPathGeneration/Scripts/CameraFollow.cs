using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour{
	public Transform target;
	float followDistance = 12;
	
	void Update (){
		iTween.MoveUpdate(gameObject,new Vector3(target.position.x,target.position.y, target.position.z - followDistance),.8f);
	}
}

