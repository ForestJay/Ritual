using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {
	
	public bool istouching;
	public int resources;
	public GameObject cCO;
	public bool hidden = false;
	
	public Sprite normal;
	public Sprite hiding;
	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start()
	{
		resources = 0;
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (hidden == true)
		{
			spriteRenderer.sprite = hiding;
		}
		
		if (hidden == false)
		{
			spriteRenderer.sprite = normal;
		}
		
		if (istouching == true && Input.GetButtonDown("Interact"))
		{
			Debug.Log("touching and e pressed");
			cCO.SendMessage("pick");
			//if (other.gameObject.GetComponent<"Bush">().berries == true)
			
			
		}
		
		if (istouching == true && Input.GetButtonDown("Hide"))
		{ 
			
			if (hidden == true)
			{
				Unhide();
				
			}
			
			else 
			{
				Hide();
			}
			
		}
	}
	
	void Hide()
	{
		cCO.SendMessage("hidden", true);
		hidden = true;
	}
	void Unhide()
	{
		cCO.SendMessage("hidden", false);
		hidden = false;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bush")
		{
			istouching = true;
			cCO = other.gameObject;
			
		}
	}
	
	void OnTriggerExit()
	{
		istouching = false;
		cCO = null;
	}
	
	void resourcecollect(int amount)
	{
		Debug.Log("picked");
		resources += amount;
	}
	
}
