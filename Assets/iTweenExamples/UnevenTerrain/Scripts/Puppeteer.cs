//using UnityEngine;
//using System.Collections;
//
//public class Puppeteer : MonoBehaviour
//{
//	public Transform character;
//	public Transform arrow; 
//	
//	void Start(){
//	}
//	
//	void Update (){
//		PlaceArrow();
//		PlaceCharacter();
//		if(Input.GetMouseButton(0)){
//			iTween.MoveTo(gameObject,new Vector3(arrow.position.x,arrow.position.y+5,arrow.position.z),2);
//		}
//	}
//	
//	void PlaceArrow(){
//		RaycastHit hit = new RaycastHit();
//		Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
//		Debug.DrawRay (cameraRay.origin, cameraRay.direction * 100);
//		if (Physics.Raycast (cameraRay.origin,cameraRay.direction,out hit, 100)) {
//			iTween.MoveUpdate(arrow.gameObject,hit.point,.9f);
//			Debug.DrawLine (this.transform.position, hit.point);
//		}	
//	}
//	
//	void PlaceCharacter(){
//		RaycastHit hit = new RaycastHit();
//		if (Input.GetKey (KeyCode.D)) {
//			character.position.x = hit.point;
//		}
//		if (Physics.Raycast (transform.position,Vector3.down,out hit, 10)) {
//			character.position=hit.point;
//			Debug.DrawLine (this.transform.position, hit.point);
//		}		
//	}
//}
//
